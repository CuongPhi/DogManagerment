using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogManage_HCMC.DTO
{
    public class PersonInfo
    {
        private string address;
        private DateTime? birthDay;
        private string eMail;
        private string phoneNum;
        private string idCardNumber; // CMND
        private uint age;
        private uint idPerson;
        private string name;
        private bool gender;
        public string Name { get => name; set => name = value; }
        public uint Age { get => age; set => age = value; }
        public uint Id { get => idPerson; set => idPerson = value; }
        public bool Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; } 
        public DateTime? BirthDay { get => birthDay; set => birthDay = value; }
        public string EMail { get => eMail; set => eMail = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string IdCardNumber { get => idCardNumber; set => idCardNumber = value; }
    }
}
