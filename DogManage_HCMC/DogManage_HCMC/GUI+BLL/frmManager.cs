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
        private List<Account> _listAcc = null;
        private List<SoftWareUser> _listUser = null;
        private List<PersonInfo> _listPSI = null;
        private BindingSource _personInforBindings = new BindingSource();
        public frmManager()
        {
            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            dtgvAllUser.DataSource = _personInforBindings;

            loadAllAccount();
            PersonInfoBiding();
        }
        void PersonInfoBiding()
        {
            tbID.DataBindings.Add(new Binding("Text", dtgvAllUser.DataSource, "IDperson", true, DataSourceUpdateMode.Never));
            tbName.DataBindings.Add(new Binding("Text", dtgvAllUser.DataSource, "Name", true, DataSourceUpdateMode.Never));
            tbAddress.DataBindings.Add(new Binding("Text", dtgvAllUser.DataSource, "Address", true, DataSourceUpdateMode.Never));
            tbPhoneNum.DataBindings.Add(new Binding("Text", dtgvAllUser.DataSource, "PhoneNum", true, DataSourceUpdateMode.Never));
            tbBirthDay.DataBindings.Add(new Binding("Text", dtgvAllUser.DataSource, "BirthDay", true, DataSourceUpdateMode.Never));
            tbIDcardNum.DataBindings.Add(new Binding("Text", dtgvAllUser.DataSource, "idcardnumber", true, DataSourceUpdateMode.Never));
            tbEmail.DataBindings.Add(new Binding("Text", dtgvAllUser.DataSource, "Email", true, DataSourceUpdateMode.Never));
            rdbtnFemale.DataBindings.Add(new Binding("Checked", dtgvAllUser.DataSource, "Gender",true, DataSourceUpdateMode.Never));
        }

        private void btnResetPassW_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Đặt lại mật khẩu cho tài khoản: {0} thành công", tbUserName.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void loadAllAccountBinding()
        {
            _personInforBindings.DataSource = PersonInfoConnection.Inst.getAllPerSonInfor();
        }
        public void loadAllAccount()
        {
            loadAllAccountBinding();
            setDataGritViewUser();
        }

        void loadUserSearchName(string name)
        {
            _personInforBindings.DataSource = PersonInfoConnection.Inst.SearchUserByName(name);
        }
        void loadUserSearchEmail(string e)
        {
            _personInforBindings.DataSource = PersonInfoConnection.Inst.SearchUserByEmail(e);
        }
        void setDataGritViewUser()
        {
            try
            {
                try
                {
                    dtgvAllUser.Columns["IDperson"].DisplayIndex = 0;
                    dtgvAllUser.Columns["IDperson"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dtgvAllUser.Columns["IDperson"].HeaderText = "Mã";

                    dtgvAllUser.Columns["Name"].DisplayIndex = 1;
                    dtgvAllUser.Columns["Name"].HeaderText = "Họ Tên";

                    dtgvAllUser.Columns["PhoneNum"].DisplayIndex = 2;
                    dtgvAllUser.Columns["PhoneNum"].HeaderText = "Điện thoại";

                    dtgvAllUser.Columns["Email"].DisplayIndex = 3;
                    dtgvAllUser.Columns["Gender"].DisplayIndex = 4;
                    dtgvAllUser.Columns["Gender"].HeaderText = "Giới tính";
                }
                catch { }
                try
                {
                    dtgvAllUser.Columns["Address"].Visible = false;
                    dtgvAllUser.Columns["idcardnumber"].Visible = false;
                    dtgvAllUser.Columns["Birthday"].Visible = false;
                }
                catch { }
            }
            catch { }
            foreach (DataGridViewColumn item in dtgvAllUser.Columns)
            {
                item.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                item.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                item.DefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
                item.ReadOnly = true;
            }

            dtgvAllUser.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbFindAcc_MouseDown(object sender, MouseEventArgs e)
        {
            //cbbFindUser.Text = "";
        }

        private void cbbFindAcc_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void cbbFindAcc_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void frmManager_Load(object sender, EventArgs e)
        {
            loadAllAccount();
            setAllControlBoxReadOnlyOnGrBox(true);
        }

        void setAllControlBoxReadOnlyOnGrBox(bool b)
        {
            SetAllControlReadOnlyOnGrboxPSI(b);
            SetAllTeboxReadOnlyOnGrboxAccount(b);
            SetAllControlReadOnlyOnGrboxSalary(b);

        }
        void SetAllControlReadOnlyOnGrboxPSI(bool b)
        {
            tbAddress.ReadOnly =
            tbID.ReadOnly =
            tbEmail.ReadOnly =
            tbPhoneNum.ReadOnly =
            tbBirthDay.ReadOnly =
            tbName.ReadOnly = b;
            pnGender.Enabled = !b;

        }

        void SetAllControlReadOnlyOnGrboxSalary(bool b)
        {

            tbMedicalCode.ReadOnly =
            tbBasicSalary.ReadOnly =
            tbBankNum.ReadOnly =
            nmrudfringe.ReadOnly = b;
        }
        void SetAllTeboxReadOnlyOnGrboxAccount(bool b)
        {
            tbUserName.ReadOnly = tbTypeAcc.ReadOnly = b;
        }
        public string getEnumAccountString(object t)
        {
            return t.ToString();
        }

        private void dtgvAllAcc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void btnViewListAcc_Click(object sender, EventArgs e)
        {
            loadAllAccount();

        }

      
        private void rdbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdbtnFemale.Checked)
            {
                rdbtnMale.Checked = true;
            }
        }

        private void cbbFindUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchUser.Text != "")
            {
                loadUserSearchName(tbSearchUser.Text);
                if (dtgvAllUser.RowCount < 2)
                    loadUserSearchEmail(tbSearchUser.Text);
                setDataGritViewUser();
            }
        }
    }
}
