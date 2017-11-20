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

    }
    public  class Dog
    {
        private typeDog typeDog;
        private string idOwner;
        private string idDog;
        private float weight;
        private DateTime? dateIn;
        private DateTime? dateOut;
        private bool isDetroy;
        private bool isInject;

        public Dog(DataRow row)
        {
            this.typeDog = (typeDog)row["typeDog"];
            this.IdOwner = row["idOwner"].ToString();
            this.idDog = row["idDog"].ToString();
            this.isDetroy = (bool)row["isDetroy"];
            this.isInject = (bool)row["isInject"];
            this.weight = (float)Convert.ToDouble(row["weight"].ToString());
            this.DateIn = (DateTime?)row["dateIn"];
            this.dateOut = new DateTime?((DateTime)dateIn);
            
        }

        public string IdOwner { get => idOwner; set => idOwner = value; }
        public string IdDog { get => idDog; set => idDog = value; }
        public float Weight { get => weight; set => weight = value; }
        public DateTime? DateIn { get => dateIn; set => dateIn = value; }
        public DateTime? DateOut { get => dateOut; set => dateOut = value; }
        public bool IsDetroy { get => isDetroy; set => isDetroy = value; }
        public bool IsInject { get => isInject; set => isInject = value; }
        internal typeDog TypeDog { get => typeDog; set => typeDog = value; }
        public long getFine()
        {
            return 1;
        }
    }
}
