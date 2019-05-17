using System;


namespace WpfApp1.entidades
{

    /// <summary>
    /// Clase que contiene los tipos de sintomas
    /// </summary>
   public class Sintoma
    {
        

        public virtual int codigoSintoma { get; set; } // clave primaria
        public virtual string descripcion { get; set; } //  descripcion del sintomas 
        public virtual string observacion { get; set; } //  observaciones que presenta el sintomas 

    }
}
