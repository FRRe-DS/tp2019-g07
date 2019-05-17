using System;

namespace WpfApp1.entidades
{
 public  class SignoVital
    {
        public virtual int idSignoVital { get; set; } // clave primaria
        public virtual int idSignoEvaluar { get; set; }

        /* public virtual ElementoEvaluacionSigno idSignoEvaluar { get; set; }*/ // clave foranea que viene de clases ElementoEvaluacionSigno
        public virtual int idExpediente { get; set; } // clave foranea que viene de Historia Clinica del Paciente
        public virtual string resultado { get; set; } //  descripcion del sintomas 
        public virtual string observacion { get; set; } //  observaciones que presenta el sintomas 
    }
}
