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
    public partial class frmAccountant : Form
    {
        private List<Bill> _listBill = null;
        public frmAccountant()
        {
            InitializeComponent();
            loadBill();
        }

        void loadBill()
        {
            _listBill = BillConnection.Inst.getListBill();
            if (_listBill != null)
            {
                int sumBill = 0;
                foreach (Bill item in _listBill)
                {
                    sumBill += item.Fine;
                }
                _listBill.Add(new Bill(-1, new DateTime(), "", sumBill, "Tổng:"));
                dtgvBill.DataSource = _listBill;

                foreach (DataGridViewColumn item in dtgvBill.Columns)
                {

                    item.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                    item.DefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
                    item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    item.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    item.ReadOnly = true;
                }

                dtgvBill.Columns["id"].DisplayIndex = 0;
                dtgvBill.Columns["id"].HeaderText = "Mã hóa đơn";
                dtgvBill.Columns["id"].Width = 75;

                dtgvBill.Columns["idOwner"].DisplayIndex = 1;
                dtgvBill.Columns["idOwner"].HeaderText = "Mã chủ";
                dtgvBill.Columns["idOwner"].Width = 75;

                dtgvBill.Columns["dateBill"].DisplayIndex = 2;
                dtgvBill.Columns["dateBill"].HeaderText = "Ngày";
                dtgvBill.Columns["dateBill"].Width = 85;

                dtgvBill.Columns["idStaff"].DisplayIndex = 3;
                dtgvBill.Columns["idStaff"].HeaderText = "Mã nhân viên";
                dtgvBill.Columns["idStaff"].Width= 90;


                dtgvBill.Columns["fine"].DisplayIndex = 4;
                dtgvBill.Columns["fine"].HeaderText = "Tiền phạt";
                dtgvBill.Columns["fine"].Width = 110;
                dtgvBill.Columns["fine"].DefaultCellStyle.Format = string.Format("c");

               // dtgvBill.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            else
            {
                MessageBox.Show("Không tải được danh sách hóa đơn");
            }
        }

        private void dtgvBill_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if( e.RowIndex == _listBill.Count-1)
            {
                if (e.ColumnIndex >= 0)
                {
                    if (e.ColumnIndex == 0)
                    {
                        e.CellStyle.ForeColor = e.CellStyle.BackColor;
                        e.CellStyle.SelectionForeColor = e.CellStyle.SelectionBackColor;
                    }
                    else if (e.ColumnIndex==4 || e.ColumnIndex == 3)
                    {
                        e.CellStyle.Font = new Font("Arial", 13F, FontStyle.Bold | FontStyle.Italic , GraphicsUnit.Pixel);

                    }
                }
            }
        }
    }
}
