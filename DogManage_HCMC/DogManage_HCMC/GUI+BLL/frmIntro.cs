using DogManage_HCMC.DTO;
using DogManage_HCMC.GUI_BLL;
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
        Account _acc = new Account();
        public frmIntro(Account acc)
        {
            _acc = acc;
            InitializeComponent();
            
        }
        private void setTypeAccount(typeAccount type)
        {
            if(typeAccount.Manager == type)
            {
                quảnLýToolStripMenuItem.Enabled = true;
            }
            else if(typeAccount.Staff == type)
            {
                nhânViênToolStripMenuItem.Enabled = true;
            }
            else
            {
                kếToánToolStripMenuItem.Enabled = true;
            }
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất ??", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManager FrmManager = new frmManager(_acc);
            FrmManager.ShowDialog();

            this.Show();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Khi bạn đăng");
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
            frmStaff FrmStaff = new frmStaff(_acc);
            FrmStaff.ShowDialog();

            this.Show();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kếToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAccountant frA = new frmAccountant();
            frA.ShowDialog();

            this.Show();
        }

        private void frmIntro_Load(object sender, EventArgs e)
        {
            nhânViênToolStripMenuItem.Enabled = quảnLýToolStripMenuItem.Enabled =
                kếToánToolStripMenuItem.Enabled = false;
            setTypeAccount(_acc.Type);
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassW frmfcp = new frmChangePassW(_acc);
            frmfcp.ShowDialog();
            if(frmfcp.IsChangedPass)
            {
                this.Close();
            }
        }

        private void đổiTTCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePersonInfor frmCPI = new frmChangePersonInfor(_acc);
            frmCPI.ShowDialog();
        }
    }
}
