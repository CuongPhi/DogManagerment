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

namespace DogManage_HCMC
{
    public partial class frmStaff : Form
    {
        private List<Dog> _listDog;

        public frmStaff()
        {
            InitializeComponent();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            loadListDog();
        }

        private void tbFindDog_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void tbFindDog_TextChanged(object sender, EventArgs e)
        {
                
        }
        void loadListDog()
        {
            _listDog = DogConnection.Inst.getListDog();
            dtgvListDog.DataSource = _listDog;
            setDatagritviewDog();
        }
        void setDatagritviewDog()
        {
            foreach (DataGridViewColumn item in dtgvListDog.Columns)
            {

                item.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                item.DefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                item.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                item.ReadOnly = true;

            }

            dtgvListDog.Columns["iddog"].DisplayIndex = 0;
            dtgvListDog.Columns["iddog"].HeaderText = "Mã";
            dtgvListDog.Columns["iddog"].Width = 50;

            dtgvListDog.Columns["typedog"].DisplayIndex = 1;
            dtgvListDog.Columns["typedog"].HeaderText = "Loại";

            dtgvListDog.Columns["weight"].DisplayIndex = 2;
            dtgvListDog.Columns["weight"].HeaderText = "Cân nặng (kg)";


            dtgvListDog.Columns["isInject"].DisplayIndex = 3;
            dtgvListDog.Columns["isInject"].HeaderText = "Tiêm phòng";

            dtgvListDog.Columns["datein"].DisplayIndex = 4;
            dtgvListDog.Columns["datein"].HeaderText = "Ngày vào";

            dtgvListDog.Columns["dateout"].DisplayIndex = 5;
            dtgvListDog.Columns["dateout"].HeaderText = "Ngày ra";

            dtgvListDog.Columns["foodmoney1"].DisplayIndex = 6;
            dtgvListDog.Columns["foodmoney1"].HeaderText = "Thức ăn";


            dtgvListDog.Columns["foodmoney1"].DefaultCellStyle.Format = String.Format("c", new CultureInfo("vi-VN"));



        }
    }
}
