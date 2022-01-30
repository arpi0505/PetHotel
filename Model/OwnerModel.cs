using System.Collections.Generic;

namespace Kosorus_Arpad_Hotel.Model
{
    public class OwnerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public ICollection<PetModel> Pet { get; set; }


    }
}
