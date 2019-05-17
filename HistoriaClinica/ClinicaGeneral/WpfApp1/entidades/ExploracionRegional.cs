using System;
namespace WpfApp1.entidades
{
    /// <summary>
    /// Clase que contiene los resultados de la exploracio regional que se realiza sobre el cuerpo humano
    /// </summary>
    public class ExploracionRegional
    {
        public virtual int idExploracionRegional { get; set; } // clave primaria
        public virtual int idExpediente { get; set; } // clave foranea que viene de Historia Clinica del Paciente
        public virtual int idElementoRegional { get; set; }
        /* public virtual ElementoRegionalEvaluar idElementoRegional { get; set; }*/ // clave foranea que viene la clase ElemetoRegionalEvaluar
        public virtual string valoracion { get; set; } //  descripcion de resultado de padecimento
        public virtual string observacion { get; set; } //  observaciones adicionales sobre el padecimiento
    }
}
