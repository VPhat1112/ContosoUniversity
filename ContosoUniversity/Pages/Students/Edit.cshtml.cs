using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Pages.Students
{
    public class EditModel : PageModel
    {
        private readonly ContosoUniversity.Data.SchoolContext _context;

        public EditModel(ContosoUniversity.Data.SchoolContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CongNhan CongNhan { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CongNhan = await _context.congNhans.FindAsync(id);

            
            return Page();

        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            var CongNhanToUpdate = await _context.congNhans.FindAsync(id);
            if (id ==null)
            {
                return NotFound();
            }
           
            try {

               
                    var entry = _context.Update (CongNhanToUpdate);
                    entry.CurrentValues.SetValues(CongNhan);
                    await _context.SaveChangesAsync();
                    return RedirectToPage("./Index");
                

            }
            catch (Exception ex) { }
            

            return Page();
        }

        private bool StudentExists(int id)
        {
            return (_context.congNhans?.Any(e => e.IDCongNhan == id)).GetValueOrDefault();
        }
    }
}
