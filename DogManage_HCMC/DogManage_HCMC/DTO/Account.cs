using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogManage_HCMC.DTO
{
    enum typeAccount
    {
        Manager,
        Staff,
        Accountant,        
    }
   public class Account
    {
        private string userName;
        private string passWord;
        private typeAccount type;

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        internal typeAccount Type { get => type; set => type = value; }
        public Account() { }
        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.Type = (typeAccount)row["type"];
            this.PassWord = row["passWord"].ToString();
        }
    }

}
