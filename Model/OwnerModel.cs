using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kosorus_Arpad_Hotel.Model
{
    public class OwnerModel
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Nume")]
        public string Name { get; set; }

        [Range(1, 100)]
        [Display(Name = "Varsta")]
        public int Age { get; set; }

        [Display(Name = "Telefon")]
        [Phone]
        public string Phone { get; set; }
        public ICollection<PetModel> Pet { get; set; }


    }
}
