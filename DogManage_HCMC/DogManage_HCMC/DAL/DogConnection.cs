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
            DataTable data = DataConnection.Inst.ExcuteQuery("select * from dog");
            foreach (DataRow item in data.Rows)
            {
                list.Add(new Dog(item));
            }
            return list;

        }
        public bool deleteDog(string id)
        {
            return DataConnection.Inst.ExcuteNoneQuery("delete from dog where idDog = '" + id + "'") > 0;
        }
        public Dog getInforByDogID(string id)
        {
            DataTable account = DataConnection.Inst.ExcuteQuery("Select * from dog where iddog = '" + id + "'");
            foreach (DataRow item in account.Rows)
            {
                return new Dog(item);
            }
            return null;
        }
        public bool addDog(Dog dog)
        {
            string sqlQue = "INSERT dbo.DOG VALUES ({0},{1}, '{2}', '{3}',  {4},  {5})";
            int weight = dog.Weight;
            int type = (int)dog.TypeDog;
            int isInJect = dog.IsInject ? 1 : 0;
            int foodMoney = dog.FoodMoney1;
            string dateIn = dog.DateIn.ToString("MM-dd-yyyy");
            string dateOut = dog.DateOut.ToString("MM-dd-yyyy");

            string sql = string.Format(sqlQue, weight, type, dateIn, dateOut, isInJect, foodMoney);
            return DataConnection.Inst.ExcuteNoneQuery(sql) > 0;
        }
        public bool eDitDog(Dog dog)
        {
            string sqlQue = "UPDATE dbo.DOG SET WEIGHT = {0}, TYPE = {1}, DATEINT= '{2}', DATEOUT ='{3}',ISINJECT = {4},FOODMONEY = {5} WHERE IDDOG = {6}";
            int weight = dog.Weight;
            int type = (int)dog.TypeDog;
            int isInJect = dog.IsInject ? 1 : 0;
            int foodMoney = dog.FoodMoney1;
            string dateIn = dog.DateIn.ToString("MM-dd-yyyy");
            string dateOut = dog.DateOut.ToString("MM-dd-yyyy");

            string sql = string.Format(sqlQue, weight, type, dateIn, dateOut, isInJect, foodMoney, dog.IdDog);

            return DataConnection.Inst.ExcuteNoneQuery(sql) > 0;
        }
    }
}
