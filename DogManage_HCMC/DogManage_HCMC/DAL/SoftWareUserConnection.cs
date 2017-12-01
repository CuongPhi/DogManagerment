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
        public SoftWareUser getUserInfor(string que)
        {
            DataTable account = DataConnection.Inst.ExcuteQuery(que);
            foreach (DataRow item in account.Rows)
            {
                return new SoftWareUser(item,false);
            }
            return null;
        }
    
        public SoftWareUser getUserByUserName(string username)
        {
            string que = string.Format("SELECT * from dbo.USERAPP u, dbo.PERSONINFO p WHERE u.IDPERSON = p.IDPERSON  and p.typepsi =1 AND U.ACCOUNT = '{0}'", username);

            return getUserInfor(que);
        }
        public SoftWareUser getUserByID(string id)
        {
            string que = string.Format("SELECT * from dbo.USERAPP u, dbo.PERSONINFO p WHERE u.IDPERSON = p.IDPERSON  and p.typepsi =1 AND p.idperson = '{0}'", id);

            return getUserInfor(que);
        }
        public List< SoftWareUser > getAllUser(string que)
        {
            DataTable account = DataConnection.Inst.ExcuteQuery(que);
            List<SoftWareUser> l = new List<SoftWareUser>();
            foreach (DataRow item in account.Rows)
            {
                l.Add(new SoftWareUser(item, true));

            }
            return l;
        }
        public List<SoftWareUser> getAllUser()
        {
            return getAllUser("Select * from personinfo pi, userapp p, account a where pi.idperson = p.idperson and a.username=  p.account  and pi.typepsi =1");
        }
        public List<SoftWareUser> getAllInforUser(string id)
        {
            string que = string.Format("Select * from personinfo pi, userapp p, account a where pi.idperson = p.idperson and pi.typepsi =1 and a.username=  p.account and  p.idperson = '{0}'", id);
            return getAllUser(que);
        }
    }
}
