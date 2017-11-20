using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogManage_HCMC.DTO
{
    public class DogOwner
    {
        private PersonInfo info;
        
        public PersonInfo Info { get => info; set => info = value; }
    }
}
