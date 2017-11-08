using DogManage_HCMC.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogManage_HCMC.DAL
{
    public class ManagerConnection
    {
        private static ManagerConnection inst;

        public static ManagerConnection Inst
        {
            get
            {
                if (inst == null)
                    inst = new ManagerConnection();
                return inst;
            }

        }
        private ManagerConnection() { }

        public DataTable getListManager()
        {
            return DataConnection.Inst.ExcuteQuery("");
        }
        public Manager getManagerByuserName(string username)
        {
            DataTable account = DataConnection.Inst.ExcuteQuery("Select * from account where userName = '" + username + "'");
            foreach (DataRow item in account.Rows)
            {
                return new Manager(item);
            }
            return null;
        }
    }
}
