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


        public SoftWareUser(DataRow r, bool isALlinfo)
        {
            try
            {
                this.BankAccountNum = r["BankNum"].ToString();
                this.Info = new PersonInfo(r);
                this.Salary = (int)r["BasicSalary"];
                this.MedicalCode = r["MedicalCOde"].ToString();
                this.FringeBenegit = (int)r["FringeBenefit"];
                this.DateJoin = (DateTime)r["DateJoin"];
                try
                {
                    this.Image = (byte[])r["img"];
                }
                catch { }
                if (isALlinfo)
                {
                    this.Account = new Account(r);
                }
            }
            catch
            { }
        }

    }
}
