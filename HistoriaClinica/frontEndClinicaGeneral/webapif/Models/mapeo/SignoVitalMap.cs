using FluentNHibernate.Mapping;
using webapif.Models.entidades;

namespace webapif.Models.mapeo
{
    public class SignoVitalMap : ClassMap<SignoVital>
    {
        public SignoVitalMap()
        {
            Id(c => c.idSignoVital);

            Map(c => c.idExpediente);
            Map(c => c.ta);
            Map(c => c.fc);
            Map(c => c.temperatura);
            Map(c => c.peso);
            Map(c => c.talla);
            Map(c => c.resultado);
            Map(c => c.observacion);

            Table("SignoVital");
        }
    }
}
