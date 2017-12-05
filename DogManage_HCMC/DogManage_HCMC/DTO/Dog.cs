using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogManage_HCMC.DTO
{
    public enum typeDog
    {
        type1 =1,
        type2= 2,
        type3= 3
    }
    public  class Dog
    {
            private typeDog typeDog;
            private int FoodMoney;
            private int idDog;
            private int weight;
            private DateTime dateIn;
            private DateTime dateOut;
            private bool isInject;
        public Dog() { }
        public Dog(DataRow row)
        {
            try
            {
                this.TypeDog = (typeDog)row["type"];
                this.FoodMoney = (int)row["FoodMoney"];
                this.idDog = (int)row["idDog"];
                this.weight = (int)row["weight"];
                this.DateIn = (DateTime)row["dateInt"];
                this.dateOut = (DateTime)row["dateout"];
                this.isInject = (bool)row["isInject"];
            }
            catch { }
        }
        public Dog(int nweigth, typeDog ntype, DateTime ndateint, DateTime ndateout, bool nisinject, int nfood)
        {
            this.Weight = nweigth;
            this.TypeDog = ntype;
            this.DateIn = ndateint;
            this.DateOut = ndateout;
            this.IsInject = nisinject;
            this.FoodMoney1 = nfood;

        }

        public int IdDog { get => idDog; set => idDog = value; }
        public int Weight { get => weight; set => weight = value; }
        public DateTime DateIn { get => dateIn; set => dateIn = value; }
        public DateTime DateOut { get => dateOut; set => dateOut = value; }
        public bool IsInject { get => isInject; set => isInject = value; }
        public int FoodMoney1 { get => FoodMoney; set => FoodMoney = value; }
        public typeDog TypeDog { get => typeDog; set => typeDog = value; }

        public long getFine()
        {
            return 1;
        }
    }
}
