using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogManage_HCMC.DTO
{
    public class Manager : Person
    {
        public Manager() : base()
        {
            base.Account.Type = typeAccount.Manager;
        }
        public override void getMyInfo()
        {
            throw new NotImplementedException();
        }
        public Manager(DataRow  dt)
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
