using System;

namespace WpfApp1.entidades
{

    /// <summary>
    /// Clase que contiene los elementos generales del cuerpo humano
    /// 
    /// </summary>
   public class ElementoGeneral
    {
   
        public virtual int idEltoGeneral { get; set; } // clave primaria
        public virtual string nombreelto { get; set; } //  descripcion de la parte del cuerpo
    }
}
