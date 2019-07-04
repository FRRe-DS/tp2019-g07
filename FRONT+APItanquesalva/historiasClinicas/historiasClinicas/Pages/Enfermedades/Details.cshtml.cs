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
    public class DetailsModel : PageModel
    {
        private readonly historiasClinicas.Models.HcContext _context;

        public DetailsModel(historiasClinicas.Models.HcContext context)
        {
            _context = context;
        }

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
    }
}
