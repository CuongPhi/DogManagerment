using DogManage_HCMC.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogManage_HCMC.DAL
{
   public class BillConnection
    {
        /// <summary>
        /// Thể hiện duy nhất của lớp
        /// </summary>
        private static BillConnection inst;

        /// <summary>
        /// getter
        /// </summary>
        public static BillConnection Inst
        {
            get
            {
                if (inst == null)
                    inst = new BillConnection();
                return inst;
            }

        }
        /// <summary>
        /// Không để hàm dựng có thể được sử dụng bên ngoài, nhằm bảo đảm thể hiện inst là duy nhất
        /// </summary>
        private BillConnection() { }

        public List<Bill> getListBill()
        {
            List<Bill> list = new List<Bill>();
            DataTable data = DataConnection.Inst.ExcuteQuery("select * from bill");
            foreach (DataRow item in data.Rows)
            {
                list.Add(new Bill(item));
            }
            return list;

        }
    }
}
