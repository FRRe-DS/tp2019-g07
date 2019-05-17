using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Internacion
{
    public class Internac_paciente
    {
        [Key]
        public int Id_internacion { get; set; }

        
        public int Id_expediente { get; set; }

        public int Id_personal { get; set; }
        public DateTime Fecha_ingreso { get; set; }
        public string Imp_diagnostica { get; set; }
        public string Tratamiento { get; set; }
    }
}

