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
    //-------------- Lớp AccountConnection, thao tác với lớp Account
    /// <summary>
    /// Lớp có nhiệm vụ kết nối tới db thông qua lớp Dataconnection
    /// Thiết kế theo mẫu singleton pattern
    ///  
    /// </summary>
    public class AccountConnection
    {
        /// <summary>
        /// Thể hiện duy nhất của lớp
        /// </summary>
        private static AccountConnection inst;

        /// <summary>
        /// getter
        /// </summary>
        public static AccountConnection Inst
        {
            get
            {
                if (inst == null)
                    inst = new AccountConnection();
                return inst;
            }

        }
        /// <summary>
        /// Không để hàm dựng có thể được sử dụng bên ngoài, nhằm bảo đảm thể hiện inst là duy nhất
        /// </summary>
        private AccountConnection() { }
        /// <summary>
        /// Kiểm tra tài khoản và mật khẩu khi đăng nhập
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passw"></param>
        /// <returns> true nếu kiểm tra có tài khoản, ngược lại false </returns>
        public bool isLogin(string userName, string passw)
        {
            string strque = string.Format("select * from account where username = '{0}' and password = '{1}'", userName, passw);
            return DataConnection.Inst.ExcuteQuery(strque).Rows.Count > 0;
        }
        /// <summary>
        /// lấy ra tất cả các account ở db và thêm vào list
        /// </summary>
        /// <returns> 
        /// list danh sách này
        /// </returns>
        public List<Account> getListAccount()
        {
            List<Account> list = new List<Account>();
            string query = "select * from Account";
            DataTable dt = DataConnection.Inst.ExcuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Account(item));

            }
            return list;
        }
        /// <summary>
        /// lấy ra toàn bộ thông tin của account bằng tài khoản đăng nhập
        /// </summary>
        /// <param name="username"></param>
        /// <returns> đối tượng account </returns>
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
        /// <summary>
        /// Cập nhập lại mật khẩu
        /// </summary>
        /// <param name="currentPassW"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool updatePassW(string newPassW, string userName)
        {
            try
            {
                string que = string.Format("UPDATE dbo.ACCOUNT SET PASSWORD = '{0}' WHERE USERNAME = '{1}'", newPassW, userName);
                return DataConnection.Inst.ExcuteNoneQuery(que) > 0;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// reset mật khẩu tài khoản đang chọn, bằng với 1
        /// </summary>
        /// <param name="banknum"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool resetPassW(string userName)
        {
            try
            {
                string que = string.Format("UPDATE dbo.ACCOUNT SET PASSWORD = '{0}' WHERE USERNAME = '{1}'", 1, userName);
                return DataConnection.Inst.ExcuteNoneQuery(que) > 0;
            }
            catch
            {
                return false;
            }
        }
        public bool userNameIsExits(string userName)
        {
            string que = string.Format("SELECT USERNAME FROM dbo.ACCOUNT WHERE USERNAME = '{0}'", userName);
            DataTable dt = DataConnection.Inst.ExcuteQuery(que);
            foreach (var item in dt.Rows)
            {
                return true;
            }
            return false;
        }
        public bool changTypeAccount(int index, string userName)
        {
            int type = 2;
            if (index == 0)
            {
                type = 3;
            }
            else if (index == 1)
            {
                type = 1;
            }
            try
            {
                string que = string.Format("UPDATE dbo.ACCOUNT SET Type = '{0}' WHERE USERNAME = '{1}'", type, userName);
                return DataConnection.Inst.ExcuteNoneQuery(que) > 0;
            }
            catch { return false; }
        }
        /// <summary>
        /// trả về đối tượng User bằng username
        /// </summary>
        /// <param name="username"></param>
        /// <returns>Đối tượng SoftWareUser </returns>
        public SoftWareUser getSoftWareUserByUserName(string username)
        {
            string que = string.Format("SELECT * from dbo.USERAPP u, dbo.PERSONINFO p WHERE u.IDPERSON = p.IDPERSON AND U.ACCOUNT = '{0}'", username);
            DataTable account = DataConnection.Inst.ExcuteQuery(que);
            foreach (DataRow item in account.Rows)
            {
                return new SoftWareUser(item, false);
            }
            return null;
        }


    }
}
