using FluentNHibernate.Mapping;
using WpfApp1.entidades;


namespace WpfApp1.mapeo
{
  public class SintomaMap: ClassMap<Sintoma>
    {
        public SintomaMap()
        {
            Id(c => c.codigoSintoma);
            Map(c => c.descripcion);
            Map(c => c.observacion);


            Table("Sintoma");
        }
    }
}
