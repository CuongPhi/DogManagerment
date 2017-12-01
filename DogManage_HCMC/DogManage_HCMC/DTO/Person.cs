using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogManage_HCMC.DTO
{
    public abstract class Person
    {
        public Person()      {   }
        private Account account;
        private  PersonInfo info;
        private string bankAccountNum;
        private int salary;
        private string medicalCode;
        private int _FringeBenegit;
        private DateTime dateJoin;

        public  PersonInfo Info { get => info; set => info = value; }
        public string BankAccountNum { get => bankAccountNum; set => bankAccountNum = value; }
        public int Salary { get => salary; set => salary = value; }
        public Account Account { get => account; set => account = value; }
        public string MedicalCode { get => medicalCode; set => medicalCode = value; }
        public int FringeBenegit { get => _FringeBenegit; set => _FringeBenegit = value; }
        public DateTime DateJoin { get => dateJoin; set => dateJoin = value; }
    }
}
