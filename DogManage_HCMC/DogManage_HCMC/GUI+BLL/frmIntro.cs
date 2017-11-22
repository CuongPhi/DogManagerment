using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogManage_HCMC
{
    public partial class frmIntro : Form
    {
        public frmIntro()
        {
            InitializeComponent();
            
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất ??", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManager FrmManager = new frmManager();
            FrmManager.ShowDialog();

            this.Show();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nội dung giúp đỡ !");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnExitFrm_Click(object sender, EventArgs e)
        {
            đăngXuấtToolStripMenuItem_Click(this, new EventArgs());

        }

        private void frmIntro_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmStaff FrmStaff = new frmStaff();
            FrmStaff.ShowDialog();

            this.Show();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kếToánToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmIntro_Load(object sender, EventArgs e)
        {

        }
    }
}
