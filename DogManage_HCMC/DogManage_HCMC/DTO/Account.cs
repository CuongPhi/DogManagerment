using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogManage_HCMC.DTO
{
    public enum typeAccount
    {
        Manager =1,
        Staff = 2,
        Accountant = 3,        
    }
   public class Account
    {
        private string userName;
        private string passWord;
        private typeAccount type;
        private string pass2;
        private bool isLock; 
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public typeAccount Type { get => type; set => type = value; }
        public string Pass2 { get => pass2; set => pass2 = value; }
        public bool IsLock { get => isLock; set => isLock = value; }
        //
        public Account() { }
        public Account(DataRow row)
        {
            
            this.PassWord = row["passWord"].ToString();
            this.Pass2= row["passWord2"].ToString();
            this.IsLock = (bool)row["isLock"];
            this.Type = (typeAccount)row["type"];
            this.UserName = row["userName"].ToString();

        }

    }

}
