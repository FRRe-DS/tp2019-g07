using System;


namespace WpfApp1.entidades
{
    /// <summary>
    /// Clase que contiene los distintos elementos que presenta el cuerpo
    /// </summary>
    public class EstadoElementoRegion
    {
        public virtual int idestadoregional { get; set; } // clave primaria
        //public virtual Region idRegion { get; set; } // clave foranea que viene la clase Regional
        public virtual Int16 idregion { get; set; } // clave foranea que viene la clase Regional
        public virtual string nomestadoelto { get; set; } //  descripcion del elemento regional

        
    }
}
