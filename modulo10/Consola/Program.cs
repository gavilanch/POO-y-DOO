using Dominio;
using Dominio.Interfaces;
using Dominio.Mapeadores;
using Infraestructura.Factorias;
using Infraestructura.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                               .AddTransient<ILog>(x => new FactoriaLoggers().ObtenerLogger("consola"))
                               .AddTransient<IRepositorioTareas, RepositorioTareas>()
                               .AddTransient<IRepositorioUsuarios, RepositorioUsuarios>()
                               .AddTransient<Mapeador>()
                               .AddTransient<IRepositorioResultadoTareasViewModel, RepositorioResultadoTareasViewModel>()
                               .AddTransient<ProcesadorDeTareas>()
                               .BuildServiceProvider();

            var procesadorTareas = serviceProvider.GetService<ProcesadorDeTareas>();
            await procesadorTareas.Procesar();
        }
    }
}
