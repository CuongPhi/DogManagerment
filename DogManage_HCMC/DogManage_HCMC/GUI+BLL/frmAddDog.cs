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
    public partial class frmAddDog : Form
    {
        private int foodMoney=0;
        public frmAddDog()
        {
            InitializeComponent();
            dtpkIn.Value = DateTime.Now;
            dtpkOut.Value = dtpkIn.Value.AddDays(3f);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nmrudDayDetroy.Enabled = true;
        }

        private void btnClearALL_Click(object sender, EventArgs e)
        {
            rdbtnType2.Checked = true;
            nmrudweigth.Value = nmrudweigth.Minimum;
            rdbtnNo.Checked = true;
            dtpkOut.Enabled = false;
            dtpkIn.Value = DateTime.Now;
            tbFoodMoney.Text = "";
            nmrudDayDetroy.Value = nmrudDayDetroy.Minimum;

            nmrudDayDetroy.Value = 3;

            nmrudDayDetroy.Enabled = false;

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

            if (DogConnection.Inst.addDog(d))
            {
                MessageBox.Show("Thêm chó thành công !");
                btnClearALL_Click(sender, e);
                foodMoney = 0;

            }
            else
            {
                MessageBox.Show("Thêm chó thất bại !");
            }
        }

        private void tbFoodMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFoodMoney_TextChanged_1(object sender, EventArgs e)
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

        private void tbFoodMoney_TabStopChanged(object sender, EventArgs e)
        {

        }

        private void nmrudDayDetroy_ValueChanged(object sender, EventArgs e)
        {
            dtpkOut.Value = dtpkIn.Value.AddDays((double)nmrudDayDetroy.Value);
        }

        private void tbFoodMoney_Enter(object sender, EventArgs e)
        {

        }

        private void dtpkIn_ValueChanged(object sender, EventArgs e)
        {
            dtpkOut.Value = dtpkIn.Value.AddDays((double)nmrudDayDetroy.Value);
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
            //if (!string.IsNullOrEmpty(tbFoodMoney.Text))
            //{
            //    tbFoodMoney.TextChanged -= tbFoodMoney_TextChanged_1;
            //    foodMoney = Int32.Parse(tbFoodMoney.Text,NumberStyles.AllowThousands);
            //    tbFoodMoney.Text = String.Format(new CultureInfo("vi-VN"), "{0:N0}", foodMoney);
            //    tbFoodMoney.Select(tbFoodMoney.Text.Length, 0);
            //}
        }

        private void tbFoodMoney_MouseClick(object sender, MouseEventArgs e)
        {

            // tbFoodMoney.TextChanged += tbFoodMoney_TextChanged_1;

        }
    }
}
