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
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int RoomID { get; set; }
        public RoomModel Room { get; set; }
    }
}
