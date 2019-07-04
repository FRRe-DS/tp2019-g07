using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace historiasClinicas.Models
{
    public class HcContext : DbContext
    {

        public DbSet<EnfermedadPaciente> EnfermedadPacientes { get; set; }
        public DbSet<InternacPaciente> InternacPacientes { get; set; }

        public HcContext(DbContextOptions<HcContext> options)
          : base(options)
        {
        }
    }

}
