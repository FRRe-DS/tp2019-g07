using FluentNHibernate.Mapping;
using WpfApp1.entidades;
namespace WpfApp1.mapeo
{
  public  class SintomaGeneralMap:ClassMap<SintomaGeneral>
    {
        public SintomaGeneralMap()
        {
            Id(c => c.idSintomaGeneral);
            Map(c => c.codigoSintoma);
            Map(c => c.idExpediente);
            Map(c => c.valoracion);

            //References(c => c.codigoSintoma).Column("codigoSintoma");

            Table("SintomaGeneral");
        }
    }
}
