namespace QLSach.GUI
{
    partial class FormMuonTra
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvPhieuMuon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDaTra = new System.Windows.Forms.CheckBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.cmbSach = new System.Windows.Forms.ComboBox();
            this.cmbDocGia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMuon = new System.Windows.Forms.Button();
            this.btnTra = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhieuMuon
            // 
            this.dgvPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuon.Location = new System.Drawing.Point(400, 80);
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.RowHeadersWidth = 51;
            this.dgvPhieuMuon.RowTemplate.Height = 24;
            this.dgvPhieuMuon.Size = new System.Drawing.Size(570, 470);
            this.dgvPhieuMuon.TabIndex = 0;
            this.dgvPhieuMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuMuon_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(300, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Mượn Trả Sách";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDaTra);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.dtpNgayTra);
            this.groupBox1.Controls.Add(this.dtpNgayMuon);
            this.groupBox1.Controls.Add(this.cmbSach);
            this.groupBox1.Controls.Add(this.cmbDocGia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 420);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu mượn";
            // 
            // chkDaTra
            // 
            this.chkDaTra.AutoSize = true;
            this.chkDaTra.Location = new System.Drawing.Point(110, 360);
            this.chkDaTra.Name = "chkDaTra";
            this.chkDaTra.Size = new System.Drawing.Size(69, 21);
            this.chkDaTra.TabIndex = 11;
            this.chkDaTra.Text = "Đã trả";
            this.chkDaTra.UseVisualStyleBackColor = true;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(110, 240);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(250, 100);
            this.txtGhiChu.TabIndex = 10;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(110, 190);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(250, 22);
            this.dtpNgayTra.TabIndex = 9;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(110, 140);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(250, 22);
            this.dtpNgayMuon.TabIndex = 8;
            // 
            // cmbSach
            // 
            this.cmbSach.FormattingEnabled = true;
            this.cmbSach.Location = new System.Drawing.Point(110, 90);
            this.cmbSach.Name = "cmbSach";
            this.cmbSach.Size = new System.Drawing.Size(250, 24);
            this.cmbSach.TabIndex = 7;
            // 
            // cmbDocGia
            // 
            this.cmbDocGia.FormattingEnabled = true;
            this.cmbDocGia.Location = new System.Drawing.Point(110, 40);
            this.cmbDocGia.Name = "cmbDocGia";
            this.cmbDocGia.Size = new System.Drawing.Size(250, 24);
            this.cmbDocGia.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ghi chú:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày Trả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày mượn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Độc Giả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trạng thái:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(480, 50);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(300, 22);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tìm kiếm:";
            // 
            // btnMuon
            // 
            this.btnMuon.BackColor = System.Drawing.Color.LightGreen;
            this.btnMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuon.Location = new System.Drawing.Point(30, 490);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(100, 40);
            this.btnMuon.TabIndex = 5;
            this.btnMuon.Text = "Mượn Sách";
            this.btnMuon.UseVisualStyleBackColor = false;
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // btnTra
            // 
            this.btnTra.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTra.Location = new System.Drawing.Point(150, 490);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(100, 40);
            this.btnTra.TabIndex = 6;
            this.btnTra.Text = "Trả Sách";
            this.btnTra.UseVisualStyleBackColor = false;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightPink;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(270, 490);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FormMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTra);
            this.Controls.Add(this.btnMuon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPhieuMuon);
            this.Name = "FormMuonTra";
            this.Text = "Quản Lý Mượn Trả Sách";
            this.Load += new System.EventHandler(this.FormMuonTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvPhieuMuon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.ComboBox cmbSach;
        private System.Windows.Forms.ComboBox cmbDocGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDaTra;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMuon;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.Button btnXoa;
    }
}
