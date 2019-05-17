using CapaAccesoAntecedentes.Models;
using System;
using CapaAccesoAntecedentes.Servicios;



namespace CapaAccesoAntecedentes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gestor CRUD para tipos de antecedentes y elementos de antecedentes a evaluar");
            Console.WriteLine("-----------------------------version 1.0------------------------------------");

            ServicioTipoAnt ta = new ServicioTipoAnt();

            TipoAntecedente a = new TipoAntecedente();

            a.NomTipoAnt = "algo";
            ta.Add(a);
            Console.WriteLine(ta);
            Console.ReadLine();
        
        }
    }
}
