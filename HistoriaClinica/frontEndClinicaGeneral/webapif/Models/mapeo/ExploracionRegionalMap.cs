using FluentNHibernate.Mapping;
using webapif.Models.entidades;

namespace webapif.Models.mapeo
{
 public   class ExploracionRegionalMap:ClassMap<ExploracionRegional>
    {
       public ExploracionRegionalMap()
        {
            Id(c => c.idExploracionRegional);    
             Map(c => c.idExpediente);
            Map(c => c.Region);
            Map(c => c.elemento);
            Map(c => c.estado);
            Map(c => c.valoracion);
            Map(c => c.observacion);

         

            Table("ExploracionRegional");
        }

    }
}
