using DogManage_HCMC.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogManage_HCMC.DAL
{
    public class SoftWareUserConnection
    {
        private static SoftWareUserConnection inst;

        public static SoftWareUserConnection Inst
        {
            get
            {
                if (inst == null)
                    inst = new SoftWareUserConnection();
                return inst;
            }

        }
        private SoftWareUserConnection() { }

        public DataTable getListStaff()
        {
            return DataConnection.Inst.ExcuteQuery("");
        }
        public SoftWareUser getUserByUserName(string username)
        {
            DataTable account = DataConnection.Inst.ExcuteQuery("Select * from account where userName = '" + username + "'");
            foreach (DataRow item in account.Rows)
            {
                return new SoftWareUser(item);
            }
            return null;
        }
        public List< SoftWareUser > getAllUser()
        {
            DataTable account = DataConnection.Inst.ExcuteQuery("Select * from personinfo pi, userapp p, account a where pi.idperson = p.idperson and a.username=  p.account");
            List<SoftWareUser> l = new List<SoftWareUser>();
            foreach (DataRow item in account.Rows)
            {
                l.Add(new SoftWareUser(item));

            }
            return l;
        }
    }
}
