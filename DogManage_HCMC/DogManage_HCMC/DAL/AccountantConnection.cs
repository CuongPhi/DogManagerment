using DogManage_HCMC.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogManage_HCMC.DAL
{
    public class AccountantConnection
    {
        private static AccountantConnection inst;

        public static AccountantConnection Inst
        {
            get
            {
                if (inst == null)
                    inst = new AccountantConnection();
                return inst;
            }

        }
        private AccountantConnection() { }
       
        public DataTable getListAccountant()
        {
            return DataConnection.Inst.ExcuteQuery("");
        }
        public Accountant getAccountantByuserName(string username)
        {
            DataTable account = DataConnection.Inst.ExcuteQuery("Select * from account where userName = '" + username + "'");
            foreach (DataRow item in account.Rows)
            {
                return new Accountant(item);
            }
            return null;
        }
    }
}
