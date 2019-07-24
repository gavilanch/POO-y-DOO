using System;

namespace modulo5
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcesarRepositorio(new RepositorioPersonasBD());
            ProcesarRepositorio(new RepositorioPersonasEnMemoria());
        }

        static void ProcesarRepositorio(IRepositorioPersonas repositorio)
        {
            repositorio.ObtenerPersonas();
        }

    }

    public interface IRepositorioPersonas
    {
        void ObtenerPersonas();
    }

    public class RepositorioPersonasBD : IRepositorioPersonas
    {
        public void ObtenerPersonas()
        {
            Console.WriteLine("Obteniendo personas de la base de datos");
        }
    }

    public class RepositorioPersonasEnMemoria : IRepositorioPersonas
    {
        public void ObtenerPersonas()
        {
            Console.WriteLine("Obteniendo personas de la memoria");
        }
    }

}
