using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSach.BUS;
using QLSach.DAL.Models;

namespace QLSach.GUI
{
    public partial class FormMuonTra : Form
    {
        private MuonTraService muonTraService = new MuonTraService();
        private SachService sachService = new SachService();

        public FormMuonTra()
        {
            InitializeComponent();
        }

        private void FormMuonTra_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Load Books
            cmbSach.DataSource = sachService.GetAll();
            cmbSach.DisplayMember = "TenSach";
            cmbSach.ValueMember = "MaSach";

            // Load DocGia
            cmbDocGia.DataSource = muonTraService.GetAllDocGia();
            cmbDocGia.DisplayMember = "TenDG";
            cmbDocGia.ValueMember = "MaDG";

            // Load Grid
            LoadGrid(muonTraService.GetAll());
        }

        private void LoadGrid(List<PhieuMuon> list)
        {
            dgvPhieuMuon.DataSource = list.Select((p, index) => new {
                STT = index + 1,
                MaPM = p.MaPM,
                TenDG = p.DocGia != null ? p.DocGia.TenDG : "",
                TenSach = p.Sach != null ? p.Sach.TenSach : "",
                NgayMuon = p.NgayMuon,
                NgayTra = p.NgayTra,
                GhiChu = p.GhiChu,
                DaTra = p.DaTra ? "Rồi" : "Chưa"
            }).ToList();

            if (dgvPhieuMuon.Columns["MaPM"] != null)
                dgvPhieuMuon.Columns["MaPM"].Visible = false;
        }

        private void ClearInput()
        {
            txtGhiChu.Text = "";
            chkDaTra.Checked = false;
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuMuon pm = new PhieuMuon();
                pm.MaDG = cmbDocGia.SelectedValue.ToString();
                pm.MaSach = cmbSach.SelectedValue.ToString();
                pm.NgayMuon = dtpNgayMuon.Value;
                pm.NgayTra = dtpNgayTra.Value;
                pm.GhiChu = txtGhiChu.Text;
                pm.DaTra = false; // Mượn mới thì chưa trả

                muonTraService.AddOrUpdate(pm);
                MessageBox.Show("Mượn sách thành công!");
                LoadGrid(muonTraService.GetAll());
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            if (dgvPhieuMuon.CurrentRow != null)
            {
                try
                {
                    int maPM = int.Parse(dgvPhieuMuon.CurrentRow.Cells["MaPM"].Value.ToString());
                    PhieuMuon pm = muonTraService.GetById(maPM);
                    if (pm != null)
                    {
                        pm.DaTra = true; // Force true when clicking "Trả Sách"
                        chkDaTra.Checked = true;
                        pm.NgayTra = dtpNgayTra.Value; // Cập nhật ngày trả thực tế
                        pm.GhiChu = txtGhiChu.Text;

                        muonTraService.AddOrUpdate(pm);
                        MessageBox.Show("Cập nhật trả sách thành công!");
                        LoadGrid(muonTraService.GetAll());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn để trả!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
             if (dgvPhieuMuon.CurrentRow != null)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa phiếu này?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                         int maPM = int.Parse(dgvPhieuMuon.CurrentRow.Cells["MaPM"].Value.ToString());
                         muonTraService.Delete(maPM);
                         MessageBox.Show("Xóa thành công!");
                         LoadGrid(muonTraService.GetAll());
                         ClearInput();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void dgvPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maPM = int.Parse(dgvPhieuMuon.Rows[e.RowIndex].Cells["MaPM"].Value.ToString());
                PhieuMuon pm = muonTraService.GetById(maPM);
                if (pm != null)
                {
                    cmbDocGia.SelectedValue = pm.MaDG;
                    cmbSach.SelectedValue = pm.MaSach;
                    dtpNgayMuon.Value = pm.NgayMuon;
                    if (pm.NgayTra != null) dtpNgayTra.Value = pm.NgayTra.Value;
                    txtGhiChu.Text = pm.GhiChu;
                    chkDaTra.Checked = pm.DaTra;
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
             if (!string.IsNullOrEmpty(txtTimKiem.Text))
            {
                LoadGrid(muonTraService.Search(txtTimKiem.Text));
            }
            else
            {
                LoadGrid(muonTraService.GetAll());
            }
        }
    }
}
