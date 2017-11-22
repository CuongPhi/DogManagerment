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
        private int age;
        private int idPerson;
        private string name;
        private bool gender;

        public PersonInfo ()
        {

        }
        public PersonInfo(DataRow r)
        {
            this.Address = r["address"].ToString();
            this.EMail = r["Email"].ToString();
            this.PhoneNum = (int)r["PhoneNum"];
            this.Age = (int)r["Age"];
            this.IdPerson = (int)r["IDperson"];
            this.Gender = (bool)r["Gender"];
            this.BirthDay = (DateTime)r["Birhday"];
            this.Name = r["Name"].ToString();
            this.IdCardNumber = (int)r["IDcardNum"];
        }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public bool Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; } 
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public string EMail { get => eMail; set => eMail = value; }
        public int PhoneNum { get => phoneNum; set => phoneNum = value; }
        public int IdCardNumber { get => idCardNumber; set => idCardNumber = value; }
        public int IdPerson { get => idPerson; set => idPerson = value; }
    }
}
