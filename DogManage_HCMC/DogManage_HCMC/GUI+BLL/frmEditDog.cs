using DogManage_HCMC.DAL;
using DogManage_HCMC.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogManage_HCMC.GUI_BLL
{
    public partial class frmEditDog : Form
    {
        private string _idDog;
        Dog _dog = null;
        private int foodMoney = 0;
        public frmEditDog(string iddog)
        {
            _idDog = iddog;
           
            InitializeComponent();
        }
        void loadInfoThisDog()
        {
            _dog = DogConnection.Inst.getInforByDogID(_idDog);
            if (_dog == null)
            {
                MessageBox.Show(string.Format("Không thể thay đổi thông tin chó {0}, xin kiểm tra lại đường truyền và thử lại sau"));
                this.Close();
            }
            else
            {
                rdbtnType1.Checked = true;
                
                if(_dog.TypeDog == typeDog.type2)
                {
                    rdbtnType2.Checked = true;
                }
                else if (_dog.TypeDog == typeDog.type3)
                {
                    rdbtnType3.Checked = true;
                }
                nmrudweigth.Value = _dog.Weight;

                dtpkIn.Value = _dog.DateIn;
                dtpkOut.Value = _dog.DateOut;

                rdbtnYes.Checked = _dog.IsInject ? true : false;

                tbFoodMoney.Text = _dog.FoodMoney1.ToString();
              //  tbFoodMoney.Text = string.Format("c", new CultureInfo("vi-VN"));
                nmrudDayDetroy.Value = (int)(dtpkOut.Value - dtpkIn.Value).TotalDays;
            }
        }

        private void frmEditDog_Load(object sender, EventArgs e)
        {
            loadInfoThisDog();
            lbTitle.Text = string.Format(lbTitle.Text + "MÃ [{0}]", _idDog);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearALL_Click(object sender, EventArgs e)
        {
            loadInfoThisDog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isInject = false;
            if (rdbtnYes.Checked) { isInject = true; }

            int wei = (int)nmrudweigth.Value;
            int timeDetroy = (int)nmrudDayDetroy.Value;

            DateTime dateIn = dtpkIn.Value;
            DateTime dateOut = dtpkOut.Value;

            typeDog ntype = typeDog.type2;
            if (rdbtnType1.Checked) { ntype = typeDog.type1; }
            else if (rdbtnType3.Checked) { ntype = typeDog.type3; }
            
            Dog d = new Dog(wei, ntype, dateIn, dateOut, isInject, foodMoney);
            d.IdDog = int.Parse(_idDog);
            if (MessageBox.Show("Bạn có chắc muốn chỉnh sửa thông tin chó này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {
                if (DogConnection.Inst.eDitDog(d))
                {
                    MessageBox.Show("Sửa thông tin chó thành công !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin chó thất bại, vui lòng kiểm tra đường truyền !");
                }
            }
        }

        private void tbFoodMoney_TextChanged(object sender, EventArgs e)
        {
            bool flag = true;
            if (tbFoodMoney.Text.Length == 1 && tbFoodMoney.Text[0] == '0')
            {
                MessageBox.Show("Không nhập số 0 đầu tiên !");
                flag = false;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(tbFoodMoney.Text, "[^0-9]"))
            {
                MessageBox.Show("Xin hãy nhập số !!");
                flag = false;
            }
            else
            {
                if (tbFoodMoney.Text.Length > 10)
                {
                    MessageBox.Show("Số quá lớn !");
                    flag = false;
                }
            }
            if (!flag)
            {
                tbFoodMoney.Text = tbFoodMoney.Text.Remove(tbFoodMoney.Text.Length - 1);
                tbFoodMoney.SelectionStart = tbFoodMoney.Text.Length;
            }
        }

        private void tbFoodMoney_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFoodMoney.Text))
            {

            }
            else
            {
                foodMoney = Int32.Parse(tbFoodMoney.Text);
            }
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void dtpkIn_ValueChanged(object sender, EventArgs e)
        {
            dtpkOut.Value = dtpkIn.Value.AddDays((double)nmrudDayDetroy.Value);
        }

        private void nmrudDayDetroy_ValueChanged(object sender, EventArgs e)
        {
            dtpkOut.Value = dtpkIn.Value.AddDays((double)nmrudDayDetroy.Value);
        }
    }
}
