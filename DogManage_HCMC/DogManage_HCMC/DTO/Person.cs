using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogManage_HCMC.DTO
{
    public abstract class Person
    {
        public Person()
        {
            account = new Account();
            info = new PersonInfo();
            bankAccountNum = "";
            salary = 0;
        }
        private Account account;
        private  PersonInfo info;
        private string bankAccountNum;
        private ulong salary;

        public  PersonInfo Info { get => info; set => info = value; }
        public string BankAccountNum { get => bankAccountNum; set => bankAccountNum = value; }
        public ulong Salary { get => salary; set => salary = value; }
        public Account Account { get => account; set => account = value; }
        
        public abstract void getMyInfo();
        public abstract void setMyInfo( Account account, PersonInfo info, string bankAccountNum, ulong salary);
        public abstract void login(string usernam, string pass);
    }
}
