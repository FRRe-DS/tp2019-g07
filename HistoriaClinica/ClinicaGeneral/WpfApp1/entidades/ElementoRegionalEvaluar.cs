
namespace WpfApp1.entidades
{
    /// <summary>
    /// Clase que contiene los distintos tipos de partes que presenta el cuerpo
    /// </summary>
    public class ElementoRegionalEvaluar
    {
        public virtual int idElementoRegional { get; set; } // clave primaria
        public virtual int idEstadoElto { get; set; } // clave foranea que viene la clase EstadoElementoRegional
        //public virtual EstadoElementoRegion idEstadoElto{ get; set; } // clave foranea que viene la clase EstadoElementoRegional
        public virtual string nombreEltoExplorado { get; set; } //  descripcion del elemento regional

       
        
    }
}
