using System;
using System.Collections.Generic;

namespace Modulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = null;
            var resultado = nombre.ContarVocales();
            var resultado2 = UtilidadesDeStrings.ContarVocales(nombre);
            //var persona1 = new Persona() { FechaNacimiento = new DateTime(1980, 1, 5) };
            //Console.WriteLine($"La edad de la personas es {persona1.Edad}");
        }

        public static void ProcesarRepositorio(IRepositorioPersonas repositorio)
        {
            repositorio.ObtenerPersonas();
        }

        enum TipoRepositorio { Memoria = 1, BD = 2 }

        static IRepositorioPersonas ObtenerRepositorio(TipoRepositorio tipoRepositorio)
        {
            switch (tipoRepositorio)
            {
                case TipoRepositorio.Memoria:
                    return new RepositorioPersonasEnMemoria();
                case TipoRepositorio.BD:
                    return new RepositorioPersonasBD();
                default:
                    throw new NotImplementedException();
            }
        }

        public class Persona
        {
            public Persona()
            {
                Console.WriteLine("constructor persona");
                Telefonos = new List<string>();
            }
            public Persona(string nombre, decimal salarioMensual)
                : this()
            {
                Nombre = nombre;
                SalarioMensual = salarioMensual;
            }

            public string Nombre { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public int Edad
            {
                get
                {
                    return FechaNacimiento.CalcularEdad("felipe");
                    return UtilidadesDeFechas.CalcularEdad(FechaNacimiento);
                }
            }
            public decimal SalarioMensual { get; set; }
            public decimal SalarioAnual
            {
                get
                {
                    return SalarioMensual * 12;
                }
            }
            public List<string> Telefonos { get; set; }

            public void Hablar()
            {

            }
            public void Hablar(int numero2, string mensaje)
            {

            }
            public void Hablar(string mensaje, int numero)
            {

            }
            public void Hablar(int numero)
            {

            }

        }
    }
}