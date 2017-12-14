using DogManage_HCMC.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogManage_HCMC.DAL
{
    public class PersonInfoConnection
    {
        private static PersonInfoConnection inst;

        public static PersonInfoConnection Inst
        {
            get
            {
                if (inst == null)
                    inst = new PersonInfoConnection();
                return inst;
            }

        }
        private PersonInfoConnection() { }


        public PersonInfo getUserByUserName(string username)
        {
            DataTable account = DataConnection.Inst.ExcuteQuery("Select * from PersonInfo where Name = '" + username + "'");
            foreach (DataRow item in account.Rows)
            {
                return new PersonInfo(item);
            }
            return null;
        }

        public List<PersonInfo> getAllPerSonInfor()
        {
            return getListUser("Select * from personinfo where typePSI = 1");
        }
        public List<PersonInfo> getListUser(string que)
        {
            List<PersonInfo> l = new List<PersonInfo>();
            DataTable dt = DataConnection.Inst.ExcuteQuery(que);
            foreach (DataRow item in dt.Rows)
            {
                l.Add(new PersonInfo(item));
            }
            return l;
        }

        public bool updatePSI(string id,string phoneNum, string idCardNum, string Address, string Email, string Birthday, int gender)
        {
            string que = string.Format("UPDATE PERSONINFO SET IDCARDNUM= '{0}', ADDRESS = N'{1}', PHONENUM= '{2}', EMAIL = '{3}', BIRHDAY = '{4}', GENDER = {5} WHERE IDPERSON = '{6}'", idCardNum, Address, phoneNum, Email, Birthday,gender ,id);
            return DataConnection.Inst.ExcuteNoneQuery(que) > 0;
        }
        public bool updateName(string name, string idperson)
        {
            string que = string.Format("  update PERSONINFO SET NAME = N'{0}' where idperson = '{1}'",name,idperson);
            return DataConnection.Inst.ExcuteNoneQuery(que) > 0;
        }
        public List<PersonInfo> SearchUserByName(string name)
        {
            return getListUser(string.Format("Select * from personinfo where typepsi = 1 and name like '%{0}%'", name));
        }

        public List<PersonInfo> SearchUserByEmail(string email)
        {
            return getListUser(string.Format("Select * from personinfo where  typepsi = 1 and  email like '%{0}%'", email));
        }
        public bool idPersonIsExits(string id)
        {
            string que = string.Format("SELECT IDPERSON FROM dbo.PERSONINFO WHERE IDPERSON = '{0}'", id);
            DataTable dt = DataConnection.Inst.ExcuteQuery(que);
            foreach (var item in dt.Rows)
            {
                return true;
            }
            return false;

        }
    }
}
