using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogManage_HCMC.GUI_BLL
{
    public partial class frmForgotPassW : Form
    {
        public frmForgotPassW()
        {
            InitializeComponent();
        }

        private void frmForgotPassW_Load(object sender, EventArgs e)
        {

        }
        private bool changPassSuccess()
        {
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(!changPassSuccess())
            {
                MessageBox.Show("Thông tin không hợp lệ, mời nhập lại");
            }
        }

        private void tbUserName_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tbUserName_TabStopChanged(object sender, EventArgs e)
        {
            if (true)
                errorProvider1.SetError(tbUserName, "Tài khoản không hợp lệ!!");
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (true)
                errorProvider1.SetError(tbUserName, "Tài khoản không hợp lệ!!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
