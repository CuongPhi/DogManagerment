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
        private int phoneNum;
        private int idCardNumber; // CMND
        private int idPerson;
        private string name;
        private bool gender;

        public PersonInfo ()
        {

        }
        public PersonInfo(DataRow r)
        {
            try
            {
                this.PhoneNum = (int)r["PhoneNum"];
                this.Address = StandardString(r["address"].ToString());
                this.Gender = (bool)r["Gender"];
                this.BirthDay = (DateTime)r["Birhday"];
                this.IdPerson = (int)r["IDperson"];
                this.Name = StandardString(r["Name"].ToString());
                this.IdCardNumber = (int)r["IDcardNum"];
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
        public int PhoneNum { get => phoneNum; set => phoneNum = value; }
        public int IdCardNumber { get => idCardNumber; set => idCardNumber = value; }
        public int IdPerson { get => idPerson; set => idPerson = value; }
    }
}
