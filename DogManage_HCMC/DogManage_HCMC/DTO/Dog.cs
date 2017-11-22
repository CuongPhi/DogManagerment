using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogManage_HCMC.DTO
{
    enum typeDog
    {
        type1 =1,
        type2= 2,
        type3= 3
    }
    public  class Dog
    {
        private typeDog typeDog;
        private int idOwner;
        private int idDog;
        private int weight;
        private DateTime dateIn;
        private DateTime dateOut;
        private bool isDetroy;
        private bool isInject;

        public Dog(DataRow row)
        {
            this.typeDog = (typeDog)row["typeDog"];
            this.IdOwner = (int)row["idOwner"];
            this.idDog = (int)row["idDog"];
            this.isDetroy = (bool)row["isDetroy"];
            this.isInject = (bool)row["isInject"];
            this.weight = (int)row["weight"];
            this.DateIn = (DateTime)row["dateIn"];
            this.dateOut = new DateTime().AddDays(3);
            
        }

        public int IdOwner { get => idOwner; set => idOwner = value; }
        public int IdDog { get => idDog; set => idDog = value; }
        public int Weight { get => weight; set => weight = value; }
        public DateTime DateIn { get => dateIn; set => dateIn = value; }
        public DateTime DateOut { get => dateOut; set => dateOut = value; }
        public bool IsDetroy { get => isDetroy; set => isDetroy = value; }
        public bool IsInject { get => isInject; set => isInject = value; }
        internal typeDog TypeDog { get => typeDog; set => typeDog = value; }
        public long getFine()
        {
            return 1;
        }
    }
}
