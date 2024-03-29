﻿using System;


namespace WpfApp1.entidades
{
 public   class SintomaGeneral
    {
        public virtual int idSintomaGeneral { get; set; } // clave primaria
        public virtual int codigoSintoma { get; set; }

        //public virtual Sintoma codigoSintoma { get; set; } // clave foranea que viene de la clase Sintoma
        public virtual int idExpediente { get; set; } // clave foranea que viene de Historia Clinica del Paciente
        public virtual string valoracion { get; set; } //  descripcion de resultado de padecimento
        public virtual string observacion { get; set; } //  observaciones adicionales sobre el padecimiento
    }
}
