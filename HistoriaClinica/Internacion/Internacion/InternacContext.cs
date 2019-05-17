using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Internacion
{
   public class InternacContext : DbContext
    {
        public DbSet<Internac_paciente> InternacionPacientes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        
            {
                optionsBuilder.UseSqlServer(@"Server=NETBOOK-PC;Database=InternacionDB;Trusted_Connection=True;");
            }
        }
    }

