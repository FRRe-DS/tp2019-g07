using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace apiAntHc.Models
{
    public class EnfermedadPaciente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEnfermedad { get; set; }

        public string Enfermedad { get; set; }

        public string Edad { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha_aprox { get; set; }

        public string Secuela { get; set; }


        public int HistoriaClinicaGral { get; set; }

    }
}
