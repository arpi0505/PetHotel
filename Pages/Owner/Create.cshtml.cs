using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Kosorus_Arpad_Hotel.Data;
using Kosorus_Arpad_Hotel.Model;

namespace Kosorus_Arpad_Hotel.Pages.Owner
{
    public class CreateModel : PageModel
    {
        private readonly Kosorus_Arpad_Hotel.Data.Kosorus_Arpad_HotelContext _context;

        public CreateModel(Kosorus_Arpad_Hotel.Data.Kosorus_Arpad_HotelContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public OwnerModel OwnerModel { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.OwnerModel.Add(OwnerModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
