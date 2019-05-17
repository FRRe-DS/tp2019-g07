using System;
using System.Linq;
using Internacion.data;
using Internacion.Servicio;

namespace Internacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Buscar();
            Console.ReadLine();


        }
        static void Actualizar()
        {


            InternacionPacienteServicio Paciente = new InternacionPacienteServicio();
            //RepositoryInternacion<Internac_paciente> paciente = new RepositoryInternacion<Internac_paciente>();
            Internac_paciente inp = new Internac_paciente()
            {
                Id_internacion = 3,
                Id_expediente = 3,
                Id_personal = 4,
                Imp_diagnostica = "cancer",
                Tratamiento = "Paracetamol",
                Fecha_ingreso = DateTime.Now
            };

            //Paciente.Add(inp);
            Paciente.Edit(inp);
            Console.WriteLine(inp.Id_internacion);
            Console.ReadLine();

        }

        static void Insertar()
        {




            InternacionPacienteServicio Paciente = new InternacionPacienteServicio();
            //RepositoryInternacion<Internac_paciente> paciente = new RepositoryInternacion<Internac_paciente>();
            Internac_paciente inp = new Internac_paciente()
            {
                //Id_internacion = 3,
                Id_expediente = 3,
                Id_personal = 4,
                Imp_diagnostica = "cancer",
                Tratamiento = "Paracetamol",
                Fecha_ingreso = DateTime.Now
            };

            Paciente.Add(inp);
            Console.WriteLine(inp.Id_internacion);
            Console.ReadLine();

        }
        static void Borrar()
        {


            InternacionPacienteServicio Paciente = new InternacionPacienteServicio();
            //RepositoryInternacion<Internac_paciente> paciente = new RepositoryInternacion<Internac_paciente>();
            Internac_paciente inp = new Internac_paciente()
            {
                Id_internacion = 3,
                //Id_expediente = 3,
                //Id_personal = 4,
                //Imp_diagnostica = "cancer",
                //Tratamiento = "Paracetamol",
                //Fecha_ingreso = DateTime.Now
            };

            Paciente.Delete(inp);
            Console.WriteLine(inp.Id_internacion);
            Console.ReadLine();

        }
    
    static void Buscar()
    {   var context = new InternacContext();
    var PacientesConMismoNombre = context.InternacionPacientes
                                      .Where(s => s.Imp_diagnostica == GetName())
                                      .ToList();
}

public static String GetName()
{
    return "cancer";
}
    }
}

