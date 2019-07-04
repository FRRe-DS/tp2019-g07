using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using historiasClinicas.Models;

namespace historiasClinicas.Pages.Enfermedades
{
    public class DeleteModel : PageModel
    {
        private readonly historiasClinicas.Models.HcContext _context;

        public DeleteModel(historiasClinicas.Models.HcContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EnfermedadPaciente = await _context.EnfermedadPacientes.FindAsync(id);

            if (EnfermedadPaciente != null)
            {
                _context.EnfermedadPacientes.Remove(EnfermedadPaciente);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
