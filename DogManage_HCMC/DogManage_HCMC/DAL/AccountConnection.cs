using DogManage_HCMC.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogManage_HCMC.DAL
{
    public class AccountConnection
    {
        private static AccountConnection inst;

        public static AccountConnection Inst
        {
            get
            {
                if (inst == null)
                    inst = new AccountConnection();
                return inst;
            }

        }
        private AccountConnection() { }
        public bool isLogin(string userName, string passw)
        {
            string strque = string.Format("select * from account where username = '{0}' and password = '{1}'",userName,passw);
            return DataConnection.Inst.ExcuteQuery(strque).Rows.Count > 0;
        }
        public List<Account> getListAccount()
        {
            List<Account> list = new List<Account>();
            string query = "select * from Account";
            foreach (DataRow item in DataConnection.Inst.ExcuteQuery(query).Rows)
            {
                Account account = new Account(item);
                list.Add(account);
            }
            return list;
        }
        public Account getAccountByuserName(string username)
        {
            string que = string.Format("select * from account where username= '{0}'", username);
            DataTable account = DataConnection.Inst.ExcuteQuery(que);
            foreach (DataRow item in account.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public bool updatePassW(string currentPassW, string userName)
        {
            try
            {
                string que = string.Format("UPDATE dbo.ACCOUNT SET PASSWORD = '{0}' WHERE USERNAME = '{1}'", currentPassW, userName);
                return DataConnection.Inst.ExcuteNoneQuery(que) > 0;
            }
            catch
            {
                return false;
            }
        }
        public SoftWareUser getSoftWareUserByUserName(string username)
        {
            string que = string.Format("SELECT * from dbo.USERAPP u, dbo.PERSONINFO p WHERE u.IDPERSON = p.IDPERSON AND U.ACCOUNT = '{0}'", username);
            DataTable account = DataConnection.Inst.ExcuteQuery(que);
            foreach (DataRow item in account.Rows)
            {
                return new SoftWareUser(item);
            }
            return null;
        }
    }
}
