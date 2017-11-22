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

namespace DogManage_HCMC.GUI_BLL
{
    public partial class frmChangePassW : Form
    {
        Account _acc = new Account();
        private bool isChangedPass = false;
        public frmChangePassW(Account acc)
        {
            _acc = acc;
            InitializeComponent();
        }

        public bool IsChangedPass { get => isChangedPass; set => isChangedPass = value; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbCurrPassW.Text != _acc.PassWord)
            {
                MessageBox.Show("Mật khẩu k đúng !!");
                return;

            }
            else if (tbNewPassW0.Text.Length < 1)
            {
                MessageBox.Show("Mật khẩu không đc rỗng !!");
                return;
            }
            else if (tbNewPassW0.Text != tbNewPassW1.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không đúng");
                return;
            }
            if (!AccountConnection.Inst.updatePassW(tbNewPassW0.Text, _acc.UserName))
            {
                MessageBox.Show("Đổi mật khẩu không thành công!");
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                MessageBox.Show("Hãy đăng nhập lại !");
                IsChangedPass = true;
                this.Close();
            }

        }
    }
}
