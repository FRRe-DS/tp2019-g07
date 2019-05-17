using FluentNHibernate.Mapping;
using WpfApp1.entidades;

namespace WpfApp1.mapeo
{
 public   class ExploracionRegionalMap:ClassMap<ExploracionRegional>
    {
       public ExploracionRegionalMap()
        {
            Id(c => c.idExploracionRegional);            
            Map(c => c.idElementoRegional);
            Map(c => c.idExpediente);
            Map(c => c.valoracion);
            Map(c => c.observacion);

            //References(c => c.idElementoRegional).Column("idElementoRegional");

            Table("ExploracionRegional");
        }

    }
}
