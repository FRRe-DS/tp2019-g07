using System;
using WpfApp1.servicio;
using WpfApp1.entidades;

namespace WpfApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestEstadoEReg();
            Console.WriteLine("Press any key...");
            Console.ReadKey();

        }

        //TEST 1: Sintomas
        static void TestSintoma()
        { 
            SintomaServico r = new SintomaServico();
            Sintoma s = new Sintoma();
            // s.codigoSintoma = 1;
            s.descripcion = "dolor";
            s.observacion = "fuerte";

            r.Insetar(s);
            Console.WriteLine(r);

        }

        //TEST 2: Elemento General
        static void TestEltoGral()
        {
            ElementoGeneralServicio lg = new ElementoGeneralServicio();
            ElementoGeneral eg = new ElementoGeneral();
            eg.nombreelto = "Aparato Digestivo";
            lg.Insetar(eg);
            Console.WriteLine(lg);
        }

        //TEST 3: Elemento Evaluacion Signo
        static void TestEESig()
        {
            ElementoEvaluacionSignoServicio sg = new ElementoEvaluacionSignoServicio();
            ElementoEvaluacionSigno es = new ElementoEvaluacionSigno();
            es.nombreSigno = "Peso";
            sg.Insetar(es);
            Console.WriteLine(es);
        }

        //TEST 4: Elemento Regional Evaluar
        //Error: referencia a idEstadoElto
        static void TestERegEvaluar()
        { 
            ElementoRegionalEvaluraServicio er = new ElementoRegionalEvaluraServicio();
            ElementoRegionalEvaluar re = new ElementoRegionalEvaluar();
            re.nombreEltoExplorado = "Normocéfalo";
            er.Insetar(re);
            Console.WriteLine(er);
        }

        //TEST 5: Estado Elemento Regional
        //Error: referencia a idRegion
        static void TestEstadoEReg()
        { 
            EstadoElementoRegionServicio est = new EstadoElementoRegionServicio();
            EstadoElementoRegion ereg = new EstadoElementoRegion();
            ereg.nomestadoelto = "Normal";
            ereg.idregion = 1;
            est.Insetar(ereg);
            Console.WriteLine(est);
        }

        //TEST 6: Region
        static void TestRegion()
        {
            RegionServicio rser = new RegionServicio();
            Region r = new Region();
            r.parteExplorada = "Tórax";
            rser.Insetar(r);
            Console.WriteLine(rser);
        }




    }

}