using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using historiasClinicas.Models;

namespace historiasClinicas.Pages.Internaciones
{
    public class EditModel : PageModel
    {
        private readonly historiasClinicas.Models.historiasClinicasContext _context;

        public EditModel(historiasClinicas.Models.historiasClinicasContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(InternacPaciente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InternacPacienteExists(InternacPaciente.Id_internacion))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool InternacPacienteExists(int id)
        {
            return _context.InternacPaciente.Any(e => e.Id_internacion == id);
        }
    }
}
