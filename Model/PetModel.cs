using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kosorus_Arpad_Hotel.Model
{
    public class PetModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int OwnerID { get; set; }
        public OwnerModel Owner { get; set; }
    }
}
