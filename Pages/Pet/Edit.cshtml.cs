using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kosorus_Arpad_Hotel.Data;
using Kosorus_Arpad_Hotel.Model;

namespace Kosorus_Arpad_Hotel.Pages.Pet
{
    public class EditModel : PageModel
    {
        private readonly Kosorus_Arpad_Hotel.Data.Kosorus_Arpad_HotelContext _context;

        public EditModel(Kosorus_Arpad_Hotel.Data.Kosorus_Arpad_HotelContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PetModel PetModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PetModel = await _context.PetModel.FirstOrDefaultAsync(m => m.Id == id);

            if (PetModel == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(PetModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PetModelExists(PetModel.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            ViewData["OwnerID"] = new SelectList(_context.Set<OwnerModel>(), "Id", "Name");
            return RedirectToPage("./Index");
        }

        private bool PetModelExists(int id)
        {
            return _context.PetModel.Any(e => e.Id == id);
        }
    }
}
