using DogManage_HCMC.DAL;
using DogManage_HCMC.DTO;
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
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }

        private void tabpAccount_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnResetPassW_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Đặt lại mật khẩu cho tài khoản: {0} thành công", tbUserName.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void showAllAccount()
        {
            dtgvAllAcc.DataSource = AccountConnection.Inst.getListAccount();
        }

        private void tbFindAcc_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void tbFindAcc_MouseLeave(object sender, EventArgs e)
        {
   
        }

        private void tbFindAcc_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbFindAcc_MouseDown(object sender, MouseEventArgs e)
        {
            cbbFindAcc.Text = "";
        }

        private void cbbFindAcc_MouseLeave(object sender, EventArgs e)
        {
            if (cbbFindAcc.Text == "")
                cbbFindAcc.Text = "Tìm kiếm";
        }

        private void cbbFindAcc_TextChanged(object sender, EventArgs e)
        {
            cbbFindAcc.Text.Replace("Tìm kiếm", "");
        }
    }
}
