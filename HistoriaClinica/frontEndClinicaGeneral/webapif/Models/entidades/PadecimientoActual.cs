using System;

namespace webapif.Models.entidades
{

    /// <summary>
    /// Clase que registra el padecimiento actual que describe el paciente
    /// </summary>
   public class PadecimientoActual
    {
         public virtual int idPadecimiento { get; set; } // clave primaria
        public virtual int idExpediente { get; set; } // clave foranea que viene de Historia Clinica del Paciente
        public virtual string descripcion { get; set; } // breve descripcion del padecimiento actual
        public virtual string valoracion { get; set; } //  descripcion de resultado de padecimento
        public virtual string observacion { get; set; } //  observaciones adicionales sobre el padecimiento

    }
}
