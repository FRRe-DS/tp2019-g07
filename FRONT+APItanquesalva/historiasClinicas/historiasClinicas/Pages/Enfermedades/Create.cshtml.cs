using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using historiasClinicas.Models;

namespace historiasClinicas.Pages.Enfermedades
{
    public class CreateModel : PageModel
    {
        private readonly historiasClinicas.Models.HcContext _context;

        public CreateModel(historiasClinicas.Models.HcContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public EnfermedadPaciente EnfermedadPaciente { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.EnfermedadPacientes.Add(EnfermedadPaciente);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}