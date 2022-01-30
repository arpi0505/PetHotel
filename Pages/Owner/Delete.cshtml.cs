using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Kosorus_Arpad_Hotel.Data;
using Kosorus_Arpad_Hotel.Model;

namespace Kosorus_Arpad_Hotel.Pages.Owner
{
    public class DeleteModel : PageModel
    {
        private readonly Kosorus_Arpad_Hotel.Data.Kosorus_Arpad_HotelContext _context;

        public DeleteModel(Kosorus_Arpad_Hotel.Data.Kosorus_Arpad_HotelContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OwnerModel OwnerModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OwnerModel = await _context.OwnerModel.FirstOrDefaultAsync(m => m.Id == id);

            if (OwnerModel == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OwnerModel = await _context.OwnerModel.FindAsync(id);

            if (OwnerModel != null)
            {
                _context.OwnerModel.Remove(OwnerModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
