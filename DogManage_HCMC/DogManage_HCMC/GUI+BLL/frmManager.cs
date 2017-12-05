﻿using DogManage_HCMC.DAL;
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
        /// <summary>
        /// các danh sách cần thiết
        /// _personInforBindings: là datasource để bindings cho các texbox
        /// </summary>  
        private BindingSource _personInforBindings = new BindingSource();
        private SoftWareUser s = null;
        private Account _acc = new Account();
        public frmManager( Account acc)
        {
            InitializeComponent();
            _acc = acc;
            loadData();
        }
        /// <summary>
        /// loadData cần thiết khi khởi tạo form
        /// </summary>
        void loadData()
        {
            dtgvAllUser.DataSource = _personInforBindings;
            
            loadAllAccount();
            PersonInfoBiding();
        }
        /// <summary>
        /// hàm tạo bindings cho các thuộc tính texbox từ datagitview
        /// </summary>
        void PersonInfoBiding()
        {
            tbID.DataBindings.Add(new Binding("Text", dtgvAllUser.DataSource, "IDperson", true, DataSourceUpdateMode.Never));
            tbName.DataBindings.Add(new Binding("Text", dtgvAllUser.DataSource, "Name", true, DataSourceUpdateMode.Never));
            tbAddress.DataBindings.Add(new Binding("Text", dtgvAllUser.DataSource, "Address", true, DataSourceUpdateMode.Never));
            tbPhoneNum.DataBindings.Add(new Binding("Text", dtgvAllUser.DataSource, "PhoneNum", true, DataSourceUpdateMode.Never));
            tbBirthDay.DataBindings.Add(new Binding("Text", dtgvAllUser.DataSource, "BirthDay", true, DataSourceUpdateMode.Never));
            tbIDcardNum.DataBindings.Add(new Binding("Text", dtgvAllUser.DataSource, "idcardnumber", true, DataSourceUpdateMode.Never));
            tbEmail.DataBindings.Add(new Binding("Text", dtgvAllUser.DataSource, "Email", true, DataSourceUpdateMode.Never));
            rdbtnFemale.DataBindings.Add(new Binding("Checked", dtgvAllUser.DataSource, "Gender", true, DataSourceUpdateMode.Never));
        }

        private void btnResetPassW_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Đặt lại mật khẩu cho tài khoản: {0} thành công", tbUserName.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // hàm lấy thông tin từ db
        void loadAllAccountBinding()
        {
            _personInforBindings.DataSource = PersonInfoConnection.Inst.getAllPerSonInfor();
        }
        /// <summary>
        /// hàm load thông tin account đang chọn
        /// </summary>
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
        /// <summary>
        /// định dạng lại các cột, tiêu đề cột, thứ tự hiện thị cho datagritview
        /// </summary>
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
        /// <summary>
        /// sự kiện khi load form này lên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmManager_Load(object sender, EventArgs e)
        {
            this.Text += _acc.UserName;
            loadAllAccount();
            setAllControlBoxReadOnlyOnGrBox(true);
        }

        /// <summary>
        /// set thuộc tính ReadOnly của các textbox ở các groupbox trên UI bằng đối số truyền vào
        /// </summary>
        /// <param name="b"></param>
        void setAllControlBoxReadOnlyOnGrBox(bool b)
        {
            SetAllControlReadOnlyOnGrboxPSI(b);
            SetAllTeboxReadOnlyOnGrboxAccount(b);
            SetAllControlReadOnlyOnGrboxSalary(b);

        }
        /// <summary>
        /// set thuộc tính ReadOnly của các textbox ở groupbox PersonInfor trên UI bằng đối số truyền vào
        /// </summary>
        /// <param name="b"></param>
        void SetAllControlReadOnlyOnGrboxPSI(bool b)
        {
            tbAddress.ReadOnly =
            tbEmail.ReadOnly =
            tbPhoneNum.ReadOnly =
            tbBirthDay.ReadOnly =
            tbName.ReadOnly = b;
            tbDateJoin.ReadOnly = b;
            tbIDcardNum.ReadOnly = b;
            pnGender.Enabled = !b;


        }
        /// <summary>
        /// set thuộc tính ReadOnly của các textbox groupbox Lương trên UI bằng đối số truyền vào
        /// </summary>
        /// <param name="b"></param>
        void SetAllControlReadOnlyOnGrboxSalary(bool b)
        {

            tbMedicalCode.ReadOnly =
            tbBasicSalary.ReadOnly =
            nmrudfringe.ReadOnly = b;
        }
        /// <summary>
        /// set thuộc tính ReadOnly của các textbox groupbox Account trên UI bằng đối số truyền vào
        /// </summary>
        /// <param name="b"></param>
        void SetAllTeboxReadOnlyOnGrboxAccount(bool b)
        {
            btnChangTypeAcc.Enabled = btnReserPassW.Enabled = cbTypeAcc.Enabled = !b;
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

        /// <summary>
        /// event check của radiobutton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// sự kiện thay đổi text của nút search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// sự kiện click của btn xem thêm thông tin tài khoản
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewMore_Click(object sender, EventArgs e)
        {
            foreach (var item in SoftWareUserConnection.Inst.getAllInforUser(tbID.Text))
            {
                s = item;
            }
            try
            {
                tbDateJoin.Text = s.DateJoin.ToShortDateString();
                tbBankNum.Text = s.BankAccountNum.ToString();
                tbBasicSalary.Text = s.Salary.ToString();
                tbMedicalCode.Text = s.MedicalCode.ToString();
                nmrudfringe.Value = s.FringeBenegit;
                tbUserName.Text = s.Account.UserName;
                if(s.Account.Type == typeAccount.Accountant)
                {
                    cbTypeAcc.SelectedItem = cbTypeAcc.Items[0];
                }
                else if (s.Account.Type == typeAccount.Staff)
                {
                    cbTypeAcc.SelectedItem = cbTypeAcc.Items[2];
                }
                else if (s.Account.Type == typeAccount.Manager)
                {
                    cbTypeAcc.SelectedItem = cbTypeAcc.Items[1];
                }

            }
            catch
            {
                MessageBox.Show("Không có thêm thông tin hiển thị");
            }

        }
        /// <summary>
        /// sự kiện click trên datagitview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgvAllUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbDateJoin.Text = string.Empty;
            tbBankNum.Text = string.Empty;
            tbBasicSalary.Text = string.Empty;
            tbMedicalCode.Text = string.Empty;
            nmrudfringe.Value = 0;
            tbUserName.Text = string.Empty;
            cbTypeAcc.Text= string.Empty;
            setAllControlBoxReadOnlyOnGrBox(true);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tbName.ReadOnly = false;
            pnGender.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tbIDcardNum.ReadOnly = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbEmail.ReadOnly = false;
            tbBirthDay.ReadOnly = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbDateJoin.ReadOnly = false;
            tbPhoneNum.ReadOnly = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbAddress.ReadOnly = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tbMedicalCode.ReadOnly = false;
            nmrudfringe.ReadOnly = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tbBasicSalary.ReadOnly = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(tbUserName.Text == "" )
            {
                MessageBox.Show("Không có thông tin đăng nhập để chỉnh sửa");
                return;
            }
            btnReserPassW.Enabled = true;
            btnChangTypeAcc.Enabled = true;
            cbTypeAcc.Enabled = true;
        }
        /// <summary>
        /// event click ở button EditAll
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditAll_Click(object sender, EventArgs e)
        {
            setAllControlBoxReadOnlyOnGrBox(false);
        }

        private void btnReserPassW_Click(object sender, EventArgs e)
        {
            if(tbUserName.Text.Length < 1)
            {
                MessageBox.Show("Tên tài khoản không đúng!");
                return;
            }
            bool _reset = AccountConnection.Inst.resetPassW(tbUserName.Text);
            if(_reset)
            {
                MessageBox.Show("Reset mật khẩu thành công !", tbUserName.Text);
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau!");
            }
            setAllControlBoxReadOnlyOnGrBox(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            setAllControlBoxReadOnlyOnGrBox(true);
        }

        private void btnChangTypeAcc_Click(object sender, EventArgs e)
        {
            if(tbUserName.Text == _acc.UserName)
            {
                MessageBox.Show("Không thể thay đổi tài khoản của chính bạn");
                return;
            }
            if(MessageBox.Show(string.Format("Bạn muốn đổi tài khoản này thành loại {0}",cbTypeAcc.Text),string.Format("Tài khoản:[{0}]",tbUserName.Text), MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (AccountConnection.Inst.changTypeAccount(cbTypeAcc.SelectedIndex, tbUserName.Text))
                {
                    MessageBox.Show("Đổi thành công");
                }
            }
        }

        private void ctmnstripDTGV_Opening(object sender, CancelEventArgs e)
        {
            if(dtgvAllUser.RowCount < 2)
            {
                e.Cancel = true;
            }
            

            
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabpAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
