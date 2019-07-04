﻿using System;
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
        private readonly historiasClinicas.Models.HcContext _context;

        public DeleteModel(historiasClinicas.Models.HcContext context)
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

            InternacPaciente = await _context.InternacPacientes.FirstOrDefaultAsync(m => m.Id_internacion == id);

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

            InternacPaciente = await _context.InternacPacientes.FindAsync(id);

            if (InternacPaciente != null)
            {
                _context.InternacPacientes.Remove(InternacPaciente);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
