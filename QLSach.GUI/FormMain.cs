using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSach.GUI
{
    public partial class FormMain : Form
    {
        private Form activeForm;

        public FormMain()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
            // Note: Can change Title label here if we add one to top bar
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1(), sender);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
             OpenChildForm(new FormReport(), sender); 
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
             OpenChildForm(new FormMuonTra(), sender); 
        }
    }
}
