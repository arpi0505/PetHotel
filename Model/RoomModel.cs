using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kosorus_Arpad_Hotel.Model
{
    public class RoomModel
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Nume")]
        public string Name { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Etaj")]
        public string Floor { get; set; }

        [Display(Name = "Detalii")]
        public string Details { get; set; }

        public ICollection<PetModel> Pet { get; set; }

    }
}
