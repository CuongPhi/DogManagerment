using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogManage_HCMC.DTO
{
    public class SoftWareUser : Person
    {
        public SoftWareUser() : base()
        {

        }
  

        public SoftWareUser(DataRow r)
        {
            this.BankAccountNum = (int)r["BankNum"];
            this.Info = new PersonInfo(r);
            this.Salary = (int)r["BasicSalary"];
            this.MedicalCode = (int)r["MedicalCOde"];
            this.FringeBenegit = (int)r["FringeBenefit"];
            this.DateJoin = (DateTime)r["DateJoin"];
           
        }

    }
}
