using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace apiAntHc.Models
{
        public class HcContext: DbContext
        {
      
            public DbSet<EnfermedadPaciente> EnfermedadPacientes { get; set; }
            public DbSet<InternacPaciente> InternacPacientes { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=nuevaDB;Trusted_Connection=True;");
            }
        }

}
