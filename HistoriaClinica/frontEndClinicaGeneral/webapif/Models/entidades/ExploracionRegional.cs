using System;
namespace webapif.Models.entidades
{
    /// <summary>
    /// Clase que contiene los resultados de la exploracio regional que se realiza sobre el cuerpo humano
    /// </summary>
    public class ExploracionRegional
    {
        public virtual int idExploracionRegional { get; set; } // clave primaria
        public virtual int idExpediente { get; set; } // clave foranea que viene de Historia Clinica del Paciente
        public virtual string Region { get; set; }//cabeza, cuello, torax,abdomen,miembros,genitales
        public virtual string elemento { get; set; }// puplias, faringes, superiores, inferiores
        public virtual Boolean estado { get; set; }//estado de cada uno de los elementos, bueno, malo
        public virtual string valoracion { get; set; } //  descripcion de resultado de padecimento
        public virtual string observacion { get; set; } //  observaciones adicionales sobre el padecimiento
    }
}
