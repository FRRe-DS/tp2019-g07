using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using historiasClinicas.Models;

namespace historiasClinicas.Pages.Enfermedades
{
    public class EditModel : PageModel
    {
        private readonly historiasClinicas.Models.HcContext _context;

        public EditModel(historiasClinicas.Models.HcContext context)
        {
            _context = context;
        }

        [BindProperty]
        public EnfermedadPaciente EnfermedadPaciente { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EnfermedadPaciente = await _context.EnfermedadPacientes.FirstOrDefaultAsync(m => m.IdEnfermedad == id);

            if (EnfermedadPaciente == null)
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

            _context.Attach(EnfermedadPaciente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnfermedadPacienteExists(EnfermedadPaciente.IdEnfermedad))
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

        private bool EnfermedadPacienteExists(int id)
        {
            return _context.EnfermedadPacientes.Any(e => e.IdEnfermedad == id);
        }
    }
}
