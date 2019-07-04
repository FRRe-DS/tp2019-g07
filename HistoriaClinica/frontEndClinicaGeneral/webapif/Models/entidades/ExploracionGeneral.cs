using System;

namespace webapif.Models.entidades
{
    /// <summary>
    /// Clase que contiene los resultados de la exploracio genera que se realiza sobre el cuerpo humano
    /// </summary>
    public class ExploracionGeneral
    {
        public virtual int idExploracionGeneral { get; set; } // clave primaria
        public virtual int idExpediente { get; set; } // clave foranea que viene de Historia Clinica del Paciente
        public virtual Boolean EdoConciencia { get; set; } //orientado , deshorientado
        public virtual string marcha { get; set; }//normal. at.marcha
        public virtual Boolean hidratacion { get; set; }//buena, deshidratado
        public virtual string coloracion { get; set; }//adecuada,palidez,icterico
        public virtual string valoracion { get; set; } //  descripcion de resultado de padecimento
        public virtual string observacion { get; set; } //  observaciones adicionales sobre el padecimiento
    }
}
