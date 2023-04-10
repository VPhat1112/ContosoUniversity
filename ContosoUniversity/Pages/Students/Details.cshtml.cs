using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly ContosoUniversity.Data.SchoolContext _context;

        public DetailsModel(ContosoUniversity.Data.SchoolContext context)
        {
            _context = context;
        }

      public CongNhan CongNhan { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CongNhan = await _context.congNhans
        .Include(s => s.bangDangKies)
        .ThenInclude(e => e.calam)
        .AsNoTracking()
        .FirstOrDefaultAsync(m => m.IDCongNhan == id);

            if (CongNhan == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
