﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using historiasClinicas.Models;

namespace historiasClinicas.Pages.Internaciones
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
        public InternacPaciente InternacPaciente { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.InternacPacientes.Add(InternacPaciente);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}