namespace QLSach.GUI
{
    partial class FormMain
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.btnMuonTra = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnMuonTra); // NEW
            this.panelMenu.Controls.Add(this.btnThongKe);
            this.panelMenu.Controls.Add(this.btnSach);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(165, 456);
            this.panelMenu.TabIndex = 0;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThongKe.Location = new System.Drawing.Point(0, 114);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(165, 49);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống Kê Báo Cáo";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnMuonTra
            // 
            this.btnMuonTra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMuonTra.FlatAppearance.BorderSize = 0;
            this.btnMuonTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuonTra.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMuonTra.Location = new System.Drawing.Point(0, 200);
            this.btnMuonTra.Name = "btnMuonTra";
            this.btnMuonTra.Size = new System.Drawing.Size(165, 49);
            this.btnMuonTra.TabIndex = 3;
            this.btnMuonTra.Text = "Quản Lý Mượn Trả";
            this.btnMuonTra.UseVisualStyleBackColor = true;
            this.btnMuonTra.Click += new System.EventHandler(this.btnMuonTra_Click);
            // 
            // btnSach
            // 
            this.btnSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSach.FlatAppearance.BorderSize = 0;
            this.btnSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSach.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSach.Location = new System.Drawing.Point(0, 65);
            this.btnSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(165, 49);
            this.btnSach.TabIndex = 1;
            this.btnSach.Text = "Quản Lý Sách";
            this.btnSach.UseVisualStyleBackColor = true;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(165, 65);
            this.panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.LightGray;
            this.lblLogo.Location = new System.Drawing.Point(26, 24);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(115, 20);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "QL Sách App";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.lblWelcome);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(165, 0);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(573, 456);
            this.panelDesktop.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(85, 204);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(387, 26);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Chào mừng bạn đến với Quản Lý Sách";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 456);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản Lý Sách - Dashboard";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnMuonTra; // NEW
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lblWelcome;
    }
}
