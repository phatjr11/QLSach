using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSach.BUS;
using QLSach.DAL.Models;

namespace QLSach.GUI
{
    public partial class Form1 : Form
    {
        private SachService sachService = new SachService();
        private bool isAdding = false;
        private bool isEditing = false;
        private string imageFolder = Path.Combine(Application.StartupPath, "Images");

        public Form1()
        {
            InitializeComponent();
            if (!Directory.Exists(imageFolder))
            {
                Directory.CreateDirectory(imageFolder);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadGrid(sachService.GetAll());
            SetControlState(false);
        }

        private void LoadComboBox()
        {
            cmbLoaiSach.DataSource = sachService.GetAllLoaiSach();
            cmbLoaiSach.DisplayMember = "TenLoai";
            cmbLoaiSach.ValueMember = "MaLoai";
        }

        private void LoadGrid(List<Sach> list)
        {
            dgvSach.DataSource = list.Select(s => new {
                MaSach = s.MaSach,
                TenSach = s.TenSach,
                NamXB = s.NamXB,
                TenLoai = s.LoaiSach != null ? s.LoaiSach.TenLoai : "",
                MaLoai = s.MaLoai // Hidden maybe
            }).ToList();
        }

        private void SetControlState(bool enabled)
        {
            txtMaSach.Enabled = enabled; // Only enable when adding
            txtTenSach.Enabled = enabled;
            txtNamXB.Enabled = enabled;
            cmbLoaiSach.Enabled = enabled;
            btnChonAnh.Enabled = enabled;

            btnLuu.Enabled = enabled;
            btnHuy.Enabled = enabled;

            btnThem.Enabled = !enabled;
            btnSua.Enabled = !enabled;
            btnXoa.Enabled = !enabled;
            dgvSach.Enabled = !enabled;
        }

        private void ResetInputs()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtNamXB.Text = "";
            if (cmbLoaiSach.Items.Count > 0) cmbLoaiSach.SelectedIndex = 0;
            picSach.Image = null;
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvSach.Rows[e.RowIndex];
                txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
                txtTenSach.Text = row.Cells["TenSach"].Value.ToString();
                txtNamXB.Text = row.Cells["NamXB"].Value.ToString();
                
                // Set ComboBox by Text or Value. Here checking Text (TenLoai)
                cmbLoaiSach.Text = row.Cells["TenLoai"].Value.ToString();

                // Load Image
                string imagePath = Path.Combine(imageFolder, txtMaSach.Text + ".jpg");
                if (File.Exists(imagePath))
                {
                    picSach.Image = Image.FromFile(imagePath);
                }
                else
                {
                    picSach.Image = null;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            isEditing = false;
            ResetInputs();
            SetControlState(true);
            txtMaSach.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng chọn sách để sửa!");
                return;
            }
            isAdding = false;
            isEditing = true;
            SetControlState(true);
            txtMaSach.Enabled = false; // Cannot change ID
            txtTenSach.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng chọn sách để xóa!");
                return;
            }

            // Requirement 2.5
            var result = MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Sach s = sachService.GetById(txtMaSach.Text);
                    if (s != null)
                    {
                        sachService.Delete(txtMaSach.Text);
                        // Delete image if exists
                        string imagePath = Path.Combine(imageFolder, txtMaSach.Text + ".jpg");
                        if (File.Exists(imagePath)) File.Delete(imagePath);

                        MessageBox.Show("Xóa thành công!");
                        LoadGrid(sachService.GetAll());
                        ResetInputs();
                    }
                    else
                    {
                        MessageBox.Show("Sách cần xóa không tồn tại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Requirement 2.6 Validation
            if (string.IsNullOrWhiteSpace(txtMaSach.Text) || string.IsNullOrWhiteSpace(txtTenSach.Text) || string.IsNullOrWhiteSpace(txtNamXB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sách!");
                return;
            }

            if (txtMaSach.Text.Length != 6)
            {
                MessageBox.Show("Mã sách phải có 6 ký tự!");
                return;
            }

            try
            {
                Sach s = new Sach();
                s.MaSach = txtMaSach.Text;
                s.TenSach = txtTenSach.Text;
                s.NamXB = int.Parse(txtNamXB.Text);
                s.MaLoai = (int)cmbLoaiSach.SelectedValue;

                if (isAdding)
                {
                    if (sachService.GetById(s.MaSach) != null)
                    {
                        MessageBox.Show("Mã sách đã tồn tại!");
                        return;
                    }
                }

                sachService.AddOrUpdate(s);

                // Save Image
                if (picSach.Image != null && picSach.Tag != null) // Tag holds source path
                {
                    string sourcePath = picSach.Tag.ToString();
                    string destPath = Path.Combine(imageFolder, s.MaSach + ".jpg");
                    // Dispose image before overwriting if needed, but we loaded generic. 
                    // To be safe, we just copy.
                     if (File.Exists(destPath)) 
                    {
                         // If we are replacing, we need to make sure we aren't locking the file.
                         // picSach.Image might be locking it if loaded from it.
                         // But for now let's try copy.
                         picSach.Image.Dispose();
                         picSach.Image = null;
                         File.Delete(destPath);
                    }
                    File.Copy(sourcePath, destPath, true);
                }

                MessageBox.Show(isAdding ? "Thêm mới thành công" : "Cập nhật thành công");
                LoadGrid(sachService.GetAll());
                SetControlState(false);
                isAdding = false; isEditing = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetControlState(false);
            isAdding = false; isEditing = false;
            ResetInputs();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picSach.Image = Image.FromFile(dlg.FileName);
                picSach.Tag = dlg.FileName; // Store path for Save
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            // Requirement 2.7
            if (!string.IsNullOrEmpty(txtTimKiem.Text))
            {
                var list = sachService.Search(txtTimKiem.Text);
                LoadGrid(list);
            }
            else
            {
                LoadGrid(sachService.GetAll());
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Bonus Export
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV Files|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("MaSach,TenSach,NamXB,TheLoai");
                    foreach (DataGridViewRow row in dgvSach.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            sb.AppendLine($"{row.Cells["MaSach"].Value},{row.Cells["TenSach"].Value},{row.Cells["NamXB"].Value},{row.Cells["TenLoai"].Value}");
                        }
                    }
                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi export: " + ex.Message);
                }
            }
        }
    }
}
