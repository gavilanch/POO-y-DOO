using Libreria;
using System;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            var clasePublica = new ClasePublicaDePrueba();
            clasePublica.MetodoPublico();

            //clasePublica.PropiedadInterna = "B";
            //var claseInterna = new ClaseInternaDePrueba(); // error
            Console.WriteLine("Hello World!");
        }
    }

    public class ClaseDerivada : ClasePublicaDePrueba
    {
        public void Prueba()
        {
            
            PropiedadProtegida = 3;
            PropiedadProtectedInternal = "desde otro proyecto";
        }
    }



}
