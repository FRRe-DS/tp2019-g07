using System;
using FluentNHibernate.Mapping;
using webapif.Models.entidades;

namespace webapif.Models.mapeo
{
 public   class PadecimientoActualMap:ClassMap<PadecimientoActual>
    {
        public PadecimientoActualMap()
        {
            Id(c => c.idPadecimiento);
            Map(c => c.idExpediente);
            Map(c => c.descripcion);
            Map(c => c.valoracion);
            Map(c => c.observacion);
            Table("PadecimientoActual");
        }
    }
}
