using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace historiasClinicas.Models
{
    public class historiasClinicasContext : DbContext
    {
        public historiasClinicasContext (DbContextOptions<historiasClinicasContext> options)
            : base(options)
        {
        }

        public DbSet<historiasClinicas.Models.InternacPaciente> InternacPaciente { get; set; }
    }
}
