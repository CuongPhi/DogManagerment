using DogManage_HCMC.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogManage_HCMC.DAL
{
    public class StaffConnection
    {
        private static StaffConnection inst;

        public static StaffConnection Inst
        {
            get
            {
                if (inst == null)
                    inst = new StaffConnection();
                return inst;
            }

        }
        private StaffConnection() { }

        public DataTable getListStaff()
        {
            return DataConnection.Inst.ExcuteQuery("");
        }
        public Staff getStaffByuserName(string username)
        {
            DataTable account = DataConnection.Inst.ExcuteQuery("Select * from account where userName = '" + username + "'");
            foreach (DataRow item in account.Rows)
            {
                return new Staff(item);
            }
            return null;
        }
    }
}
