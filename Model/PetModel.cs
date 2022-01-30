using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kosorus_Arpad_Hotel.Model
{
    public class PetModel
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Nume")]
        public string Name { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Tip animal")]
        public string Species { get; set; }

        [Display(Name = "Persoana contact")]
        public int OwnerID { get; set; }
        public OwnerModel Owner { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data intrare")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data iesire")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Camera")]
        public int RoomID { get; set; }
        public RoomModel Room { get; set; }
    }
}
