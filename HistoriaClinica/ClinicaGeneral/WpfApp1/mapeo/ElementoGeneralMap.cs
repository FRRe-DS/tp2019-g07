using System;
using FluentNHibernate.Mapping;
using WpfApp1.entidades;

namespace WpfApp1.mapeo
{
  public  class ElementoGeneralMap:ClassMap<ElementoGeneral>
    {
        public ElementoGeneralMap()
        {
            Id(c => c.idEltoGeneral);
            Map(c => c.nombreelto);

            Table("ElementoGeneral");
        }
    }
}
