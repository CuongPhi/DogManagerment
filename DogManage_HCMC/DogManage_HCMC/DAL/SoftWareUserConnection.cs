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
                return new SoftWareUser(item, false);
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
        public List<SoftWareUser> getAllUser(string que)
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
        public bool bankNumIsExits(string bankNum)
        {
            string que = string.Format("SELECT BANKNUM FROM dbo.USERAPP WHERE BANKNUM = '{0}'", bankNum);
            DataTable dt = DataConnection.Inst.ExcuteQuery(que);
            foreach (var item in dt.Rows)
            {
                return true;
            }
            return false;
        }
        public bool saveImage(byte[] image, string id)
        {
            string sql = "update userapp set img = (@image) where idperson = '" + id + "'";
            return DataConnection.Inst.saveImage(sql, image);
        }

        public bool updateMedicalCode(string med, string id)
        {
            string que = string.Format("  update userapp SET medicalcode = '{0}' where idperson = '{1}'", med, id);
            return DataConnection.Inst.ExcuteNoneQuery(que) > 0;
        }
        public bool addStaff(string id, string userName, string bankNum, string basicSalary, int type)
        {

            string newAccount = string.Format("INSERT dbo.ACCOUNT VALUES ('{0}',    '1',  '1'  ,    {1},    0    )", userName, type);
            string newPSI = string.Format("INSERT dbo.PERSONINFO   VALUES ('{0}', '', N'', GETDATE(), N'', '', N'', 0, 1) ", id);
            string newUser = string.Format("INSERT dbo.USERAPP VALUES ('{0}', '{1}','','{2}', 0, GETDATE(), {3},   NULL ) ", id, bankNum, userName, basicSalary);
            return
              DataConnection.Inst.ExcuteNoneQuery(newAccount) > 0 &&
              DataConnection.Inst.ExcuteNoneQuery(newPSI) > 0 &&
              DataConnection.Inst.ExcuteNoneQuery(newUser) > 0;

        }
        public bool managerUpdateForStaff(string id, string bankNum = null, string basicSlary = null, string fringe = null)
        {
            if (bankNum == null && basicSlary == null && fringe == null)
            {
                return false;
            }

            string val = "";
            if (bankNum != null)
            {
                val += string.Format(" banknum = '{0}'", bankNum);
            }
            if (basicSlary != null)
            {
                val += string.Format(" , basicsalary = {0}", basicSlary);
            }
            if (fringe != null)
            {
                val += string.Format(" , fringebenefit = {0}", fringe);
            }

            string que = string.Format("update userapp set {0} where idperson = '{1}'", val, id);
            return DataConnection.Inst.ExcuteNoneQuery(que) > 0;
        }
    }
}
