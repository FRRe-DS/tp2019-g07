using System;
using System.Collections.Generic;
using System.Text;
using Internacion.data;
using Microsoft.EntityFrameworkCore;


namespace Internacion.Servicio
{
    public class InternacionPacienteServicio : RepositoryInternacion<Internac_paciente>
    {
       public InternacionPacienteServicio()
        {
            //InternacContext dbc = new InternacContext();
        }
    }
}
