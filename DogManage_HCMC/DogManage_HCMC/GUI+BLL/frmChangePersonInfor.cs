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
    public partial class frmChangePersonInfor : Form
    {
        //Form này có thuộc tính account để lưu tài khoản đang đăng nhập
        Account _acc = new Account();
        public frmChangePersonInfor(Account acc)
        {
            _acc = acc;
            InitializeComponent();
        }
        //
        // Load tất cả thông tin của tài khoản đang đăng nhập
        public void loadAllInfoAccount()
        {
           
            SoftWareUser user = SoftWareUserConnection.Inst.getUserByUserName(_acc.UserName);
            if (user==null)
            {
                MessageBox.Show("Tải thông tin thất bại, vui lòng thử lại sau !");
                this.Close();
            }
            else
            {
                user.Account = _acc;
                loadUser(user);
            }
        }
        // Thay đổi text của các control hiện thị ở UI theo tài khoản đang đăng nhập
        public void loadUser(SoftWareUser s)
        {
            tbAddress.Text = s.Info.Address;
            tbBirthDay.Text = s.Info.BirthDay.ToShortDateString();
            tbEmail.Text = s.Info.EMail;
            tbIDCardNum.Text = s.Info.IdCardNumber.ToString();
            tbName.Text = s.Info.Name;
            tbPhoneNum.Text = s.Info.PhoneNum.ToString();
            tbID.Text = s.Info.IdPerson.ToString();
            if(s.Info.Gender==false)
            {
                cbMale.Checked = true;
            }
            else
            {
                cbFeMale.Checked = true;
            }
            tbUserName.Text = s.Account.UserName;
            tbPass.Text = s.Account.PassWord;
            tbTypeAcc.Text = s.Account.Type.ToString();

            tbMedicalCode.Text = s.MedicalCode.ToString();
            tbFringeBenefit.Text = s.FringeBenegit.ToString();
            tbDateJoin.Text = s.DateJoin.ToShortDateString();

            tbBasicSalary.Text = s.Salary.ToString();
            TbBankNumber.Text = s.BankAccountNum.ToString();
            
        }
        private void gbPersonalInfo_Enter(object sender, EventArgs e)
        {

        }

        private void cbMale_CheckStateChanged(object sender, EventArgs e)
        {
          
        }

        private void cbMale_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cbFeMale_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void frmChangePersonInfor_Load(object sender, EventArgs e)
        {
            loadAllInfoAccount();
        }
    }
}
