using System;

namespace webapif.Models.entidades
{
    public class SignoVital
    {
        public virtual int idSignoVital { get; set; } // clave primaria
        public virtual int idExpediente { get; set; } // clave foranea que viene de Historia Clinica del Paciente
        public virtual string ta { get; set; }// unidad mmHg
        public virtual string fc { get; set; }//unidad lpm
        public virtual string temperatura { get; set; }// unidad grados centigrados
        public virtual string peso { get; set; }//unidad kg
        public virtual string talla { get; set; }// unidad cm
        public virtual string resultado { get; set; } //  descripcion del sintomas 
        public virtual string observacion { get; set; } //  observaciones que presenta el sintomas 
    }
}
