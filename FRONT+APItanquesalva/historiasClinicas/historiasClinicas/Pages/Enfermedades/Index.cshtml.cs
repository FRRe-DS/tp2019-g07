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
    public class IndexModel : PageModel
    {
        private readonly historiasClinicas.Models.HcContext _context;

        public IndexModel(historiasClinicas.Models.HcContext context)
        {
            _context = context;
        }

        public IList<EnfermedadPaciente> EnfermedadPaciente { get;set; }

        public async Task OnGetAsync()
        {
            EnfermedadPaciente = await _context.EnfermedadPacientes.ToListAsync();
        }
    }
}
