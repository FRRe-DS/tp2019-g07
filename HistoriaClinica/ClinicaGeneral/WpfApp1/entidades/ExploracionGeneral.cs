using System;

namespace WpfApp1.entidades
{
    /// <summary>
    /// Clase que contiene los resultados de la exploracio genera que se realiza sobre el cuerpo humano
    /// </summary>
    public class ExploracionGeneral
    {
        public virtual int idExploracionGeneral { get; set; } // clave primaria
        public virtual int idExpediente { get; set; } // clave foranea que viene de Historia Clinica del Paciente
        public virtual int idEltoEvaluar { get; set; }
        /*public virtual ElementoGeneral idEltoEvaluar { get; set; }*/ // clave foranea que viene la clase ElemetoGeneral
        public virtual string valoracion { get; set; } //  descripcion de resultado de padecimento
        public virtual string observacion { get; set; } //  observaciones adicionales sobre el padecimiento
    }
}
