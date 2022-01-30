using System.Collections.Generic;

namespace Kosorus_Arpad_Hotel.Model
{
    public class RoomModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public ICollection<PetModel> Pet { get; set; }

    }
}
