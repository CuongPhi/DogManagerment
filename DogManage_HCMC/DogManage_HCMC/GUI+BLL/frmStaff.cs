using DogManage_HCMC.DAL;
using DogManage_HCMC.DTO;
using DogManage_HCMC.GUI_BLL;
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
        private Account _acc = new Account();
        private int rowIndex = -1;
        private string idDogSelected = "";
        public frmStaff(Account acc)
        {
            _acc = acc;
            InitializeComponent();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            this.Text += _acc.UserName;
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
            dtgvListDog.Columns["iddog"].Width = 60;

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


            dtgvListDog.Columns["foodmoney1"].DefaultCellStyle.Format = String.Format("c");
            
        }

        private void btnViewListUser_Click(object sender, EventArgs e)
        {
            loadListDog();
        }

        private void tìmTheoTênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(rowIndex < 0)
            {
                MessageBox.Show("Nhấn đúp chuột vào để chọn chó muốn sửa và thử lại!");
            }
            if (idDogSelected != "" && idDogSelected.Length > 0)
            {
                frmEditDog frmEditDog = new frmEditDog(idDogSelected);
                frmEditDog.ShowDialog();
                this.loadListDog();
            }
        }

        private void dtgvListDog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtgvListDog_SelectionChanged(object sender, EventArgs e)
        {


        }

        private void dtgvListDog_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowIndex = -1;
            idDogSelected = "";
        }

        private void dtgvListDog_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dtgvListDog_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idDogSelected = "";
            if (rowIndex >= 0)
            {
                dtgvListDog.Rows[rowIndex].Selected = false;
            }
            if (e.Button == MouseButtons.Left)
            {
                rowIndex = e.RowIndex;
                if (rowIndex >= 0)
                {
                    dtgvListDog.Rows[rowIndex].Selected = true;
                    idDogSelected = dtgvListDog[0, rowIndex].Value.ToString();

                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
          
            if (idDogSelected != "" && idDogSelected.Length > 0)
            {
                if (MessageBox.Show("Bạn mún xóa chó có mã " + idDogSelected, "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    if (DogConnection.Inst.deleteDog(idDogSelected))
                    {
                        loadListDog();
                        MessageBox.Show("Xóa thành công");
                    }                  
                    else
                    {
                        MessageBox.Show("Không thể xóa, vui lòng kiểm tra kết nối hoặc kiểm tra ràng buộc thông tin");
                    }
                }
            }
            else if(rowIndex < 0)
            {
                MessageBox.Show("Nhấn đúp chuột vào thông tin chó muốn xóa và thử lại!");
            }
            else
            {
                MessageBox.Show("Không thể xóa chó này");
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddDog frmAddDog = new frmAddDog();
            frmAddDog.ShowDialog();
            loadListDog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}