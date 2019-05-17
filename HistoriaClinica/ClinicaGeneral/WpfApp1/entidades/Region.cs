using System;

namespace WpfApp1.entidades
{
   
    /// <summary>
    /// clase que contiene todas regiones del cuerpo humano
    /// </summary>
   public class Region
    {
        public virtual int idRegion { get; set; } // clave primaria
        public virtual string parteExplorada { get; set; } //  descripcion de la parte del cuerpo

    }
}
