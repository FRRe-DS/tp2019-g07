using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using historiasClinicas.Models;

namespace historiasClinicas.Pages.Internaciones
{
    public class DeleteModel : PageModel
    {
        private readonly historiasClinicas.Models.historiasClinicasContext _context;

        public DeleteModel(historiasClinicas.Models.historiasClinicasContext context)
        {
            _context = context;
        }

        [BindProperty]
        public InternacPaciente InternacPaciente { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            InternacPaciente = await _context.InternacPaciente.FirstOrDefaultAsync(m => m.Id_internacion == id);

            if (InternacPaciente == null)
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

            InternacPaciente = await _context.InternacPaciente.FindAsync(id);

            if (InternacPaciente != null)
            {
                _context.InternacPaciente.Remove(InternacPaciente);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
