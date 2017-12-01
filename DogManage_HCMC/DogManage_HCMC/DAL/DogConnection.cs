using DogManage_HCMC.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogManage_HCMC.DAL
{
    public class DogConnection
    {
        private static DogConnection inst;

        public static DogConnection Inst
        {
            get
            {
                if (inst == null)
                    inst = new DogConnection();
                return inst;
            }

        }
        private DogConnection() { }
       
        public List<Dog> getListDog()
        {
            List<Dog> list = new List<Dog>();
            DataTable data =  DataConnection.Inst.ExcuteQuery("select * from dog");
            foreach (DataRow item in data.Rows)
            {
                list.Add(new Dog(item));    
            }
            return list;

        }
        public Dog getInforByDogName(string dogname)
        {
            DataTable account = DataConnection.Inst.ExcuteQuery("Select * from account where userName = '" + dogname + "'");
            foreach (DataRow item in account.Rows)
            {
                return new Dog(item);
            }
            return null;
        }
    }
}
