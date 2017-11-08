using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogManage_HCMC.DTO
{
    public class Staff : Person
    {
        public Staff() : base()
        {
            base.Account.Type = typeAccount.Staff;
        }
        public override void getMyInfo()
        {
            throw new NotImplementedException();
        }

        public Staff(DataRow dt)
        {

        }
        public override void login(string usernam, string pass)
        {
            throw new NotImplementedException();
        }

        public override void setMyInfo(Account account, PersonInfo info, string bankAccountNum, ulong salary)
        {
            throw new NotImplementedException();
        }
    }
}
