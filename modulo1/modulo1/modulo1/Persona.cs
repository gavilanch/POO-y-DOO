using System;
using System.Collections.Generic;
using System.Text;

namespace modulo1
{
    public class Persona
    {
        public string Nombre { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        private int distancia;

        public void Caminar(int pasos)
        {
            Console.WriteLine($"{Nombre} está caminando…");
            distancia += pasos;
        }
    }
}
