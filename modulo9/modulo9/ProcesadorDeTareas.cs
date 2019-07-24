using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo9
{
    public class ProcesadorDeTareas
    {
        private readonly ILog logger;
        private readonly IRepositorioTareas repositorioTareas;
        private readonly IRepositorioUsuarios repositorioUsuarios;
        private readonly Mapeador mapeador;
        private readonly IRepositorioResultadoTareasViewModel repositorioResultadoTareasViewModel;

        public ProcesadorDeTareas(ILog logger,
            IRepositorioTareas repositorioTareas,
            IRepositorioUsuarios repositorioUsuarios,
            Mapeador mapeador,
            IRepositorioResultadoTareasViewModel repositorioResultadoTareasViewModel)
        {
            this.logger = logger;
            this.repositorioTareas = repositorioTareas;
            this.repositorioUsuarios = repositorioUsuarios;
            this.mapeador = mapeador;
            this.repositorioResultadoTareasViewModel = repositorioResultadoTareasViewModel;
        }

        public async Task Procesar()
        {
            try
            {
                logger.Log("Inicio de procesamiento");

                var tareas = await repositorioTareas.ObtenerTareas();
                var tareasNoRealizadas = tareas.Where(x => !x.Completed).ToList();
                var usuarios = await repositorioUsuarios.ObtenerUsuarios();

                logger.Log("Inicio transformación a ViewModels");
                var tareasViewModel = mapeador.Mapear(tareasNoRealizadas, usuarios);

                logger.Log("Inicio escritura de tareas en archivo");
                repositorioResultadoTareasViewModel.Guardar(tareasViewModel);
            }
            catch (Exception ex)
            {
                logger.LogException(ex);
            }
        }
    }

}
