using DogManage_HCMC.DAL;
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
    public partial class frmAddStaff : Form
    {
        public frmAddStaff()
        {
            InitializeComponent();
            cbTypeAcc.SelectedIndex = 0;
        }
        bool checkInfor()
        {
            bool flag = true; 

            if (tbUserName.Text.Length < 3 || tbUserName.Text.Length > 10)
            {
                erP.SetError(tbUserName, "Tên đăng nhập ít nhất 3 và không quá 10 ký tự !");
                flag = false;
            }
            else if(AccountConnection.Inst.userNameIsExits(tbUserName.Text))
            {
                erP.SetError(tbUserName, "Tên đăng nhập đã tồn tại !" );
                flag = false;
            }
            else
            {
                erP.SetError(tbUserName, "");
            }

            if (tbID.Text.Length < 3 || tbID.Text.Length > 5)
            {
                erP.SetError(tbID, "Mã nhân viên ít nhất 3 và không quá 5 ký tự !");
                flag = false;
            }
            else if (PersonInfoConnection.Inst.idPersonIsExits(tbID.Text))
            {
                erP.SetError(tbID, "Mã này đã tồn tại !");
                flag = false;
            }
            else
            {
                erP.SetError(tbID, "");
            }

            if (tbBankNum.Text.Length < 10 || tbBankNum.Text.Length > 20)
            {
                erP.SetError(tbBankNum, "Số tài khoản ít nhất 10 và tối đa 20");
                flag = false;
            }
            else if (SoftWareUserConnection.Inst.bankNumIsExits(tbBankNum.Text))
            {
                erP.SetError(tbBankNum, "Số tài khoản đã tồn tại !");
                flag = false;
            }
            else
            {
                erP.SetError(tbBankNum, "");
            }


            if (numericUpDown1.Value < 1000000)
            {
                erP.SetError(numericUpDown1, "Lương cơ bản phải lớn hơn 1 triệu !");
                flag = false;
            }
            else
            {
                erP.SetError(numericUpDown1, "");
            }


            return flag;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if(!checkInfor())
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin !");
                return;
            }
            string slary = numericUpDown1.Value.ToString();
            int indexComboboxAccountType = cbTypeAcc.SelectedIndex;
            int type = 2;
            if(indexComboboxAccountType==0)
            {
                type = 3;
            }
            else if (indexComboboxAccountType == 1)
            {
                type = 1;
            }
            if (MessageBox.Show("Bạn muốn thêm nhân viên này vào dữ liệu??","",MessageBoxButtons.OK) == DialogResult.OK)
            {
                if(SoftWareUserConnection.Inst.addStaff(tbID.Text,tbUserName.Text,tbBankNum.Text,slary,type))
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại, vui lòng thử lại sau");
                }
            }
        }
    }
}
