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
    public class IndexModel : PageModel
    {
        private readonly historiasClinicas.Models.historiasClinicasContext _context;

        public IndexModel(historiasClinicas.Models.historiasClinicasContext context)
        {
            _context = context;
        }

        public IList<InternacPaciente> InternacPaciente { get;set; }

        public async Task OnGetAsync()
        {
            InternacPaciente = await _context.InternacPaciente.ToListAsync();
        }
    }
}
