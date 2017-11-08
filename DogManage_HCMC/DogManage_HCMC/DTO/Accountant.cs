using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogManage_HCMC.DTO
{
    public class Accountant: Person
    {
        public Accountant() : base()
        {
            base.Account.Type = typeAccount.Accountant;
        }
        public override void getMyInfo()
        {

        }
        public Accountant(DataRow dt)
        {

        }
        public override void setMyInfo(Account account, PersonInfo info, string bankAccountNum, ulong salary)
        {
            throw new NotImplementedException();
        }

        public override void login(string usernam, string pass)
        {
            throw new NotImplementedException();
        }
    }
}
