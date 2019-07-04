using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace historiasClinicas.Models
{
    public class InternacPaciente
    {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public int Id_internacion { get; set; }


        public int Id_expediente { get; set; }

        public int Id_personal { get; set; }


        [DataType(DataType.Date)]
        public DateTime Fecha_ingreso { get; set; }

        public string Imp_diagnostica { get; set; }
        public string Tratamiento { get; set; }
        public int HistoriaClinicaGral { get; set; }

    }
}
