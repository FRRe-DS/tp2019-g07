using System;

using FluentNHibernate.Mapping;
using WpfApp1.entidades;

namespace WpfApp1.mapeo
{
 public  class RegionMap:ClassMap<Region>
    {
        public RegionMap()
        {
            Id(c => c.idRegion);
            Map(c => c.parteExplorada);
          
            Table("Region");
        }
    }
}
