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
    public class IndexModel : PageModel
    {
        private readonly Kosorus_Arpad_Hotel.Data.Kosorus_Arpad_HotelContext _context;

        public IndexModel(Kosorus_Arpad_Hotel.Data.Kosorus_Arpad_HotelContext context)
        {
            _context = context;
        }

        public IList<OwnerModel> OwnerModel { get;set; }

        public async Task OnGetAsync()
        {
            OwnerModel = await _context.OwnerModel.ToListAsync();
        }
    }
}
