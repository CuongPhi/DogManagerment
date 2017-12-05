using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogManage_HCMC.DTO
{
    /// <summary>
    /// Class Bill mô tả hóa đơn chủ đến nhận chó
    /// </summary>
   public class Bill
    {
        /// <summary>
        /// các thuộc tính của lớp
        /// </summary>
        int id;
        DateTime dateBill;
        string idOwner;
        int fine;
        string idStaff;

        /// <summary>
        /// hàm dựng, đùng để lấy data từ CSDL
        /// </summary>
        /// <param name="row"></param>
        public Bill(DataRow row)
        {
            try
            {
                this.Id = (int)row["idbill"];
                this.IdOwner = row["idowner"].ToString();
                this.DateBill = (DateTime)row["daybill"];
                this.IdStaff = row["idStaff"].ToString();
                this.Fine = (int)row["fine"];    
            }
            catch { }
        }
        public Bill(int _id, DateTime _dateBill, string _idOwner, int _fine, string _idStaff)
        {
            this.Id = _id;
            this.DateBill = _dateBill;
            this.IdOwner = _idOwner;
            this.IdStaff = _idStaff;
            this.Fine = _fine;
        }
        /// <summary>
        /// các getter/ setter
        /// </summary>
        public int Id { get => id; set => id = value; }
        public DateTime DateBill { get => dateBill; set => dateBill = value; }
        public string IdOwner { get => idOwner; set => idOwner = value; }
        public int Fine { get => fine; set => fine = value; }
        public string IdStaff { get => idStaff; set => idStaff = value; }
    }
}
