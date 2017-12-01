using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogManage_HCMC.DTO
{
    public class PersonInfo
    {
        private string address;
        private DateTime birthDay;
        private string eMail;
        private string phoneNum;
        private string idCardNumber; // CMND
        private string idPerson;
        private string name;
        private bool gender;

        public PersonInfo ()
        {

        }
        public PersonInfo(DataRow r)
        {
            try
            {
                this.PhoneNum =r["PhoneNum"].ToString();
                this.Address = StandardString(r["address"].ToString());
                this.Gender = (bool)r["Gender"];
                this.BirthDay = (DateTime)r["Birhday"];
                this.IdPerson =r["IDperson"].ToString();
                this.Name = StandardString(r["Name"].ToString());
                this.IdCardNumber = r["IDcardNum"].ToString();
                this.EMail = r["Email"].ToString().Trim().ToLower();          
            }
            catch
            { }
          
        }
     
        public string StandardString(string strInput)
        {
            strInput = strInput.Trim().ToLower();
            while (strInput.Contains("  "))
                strInput = strInput.Replace("  ", " ");
            string strResult = "";
            string[] arrResult = strInput.Split(' ');
            foreach (string item in arrResult)
                strResult += item.Substring(0, 1).ToUpper() + item.Substring(1) + " ";
            return strResult.TrimEnd();
        }
        public string Name { get => name; set => name = value; }
        public bool Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; } 
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public string EMail { get => eMail; set => eMail = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string IdCardNumber { get => idCardNumber; set => idCardNumber = value; }
        public string IdPerson { get => idPerson; set => idPerson = value; }
    }
}
