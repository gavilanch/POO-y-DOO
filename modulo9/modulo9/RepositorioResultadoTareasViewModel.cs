using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace modulo9
{
    public interface IRepositorioResultadoTareasViewModel
    {
        void Guardar(List<TareaViewModel> tareas);
    }

    public class RepositorioResultadoTareasViewModel : IRepositorioResultadoTareasViewModel
    {
        public void Guardar(List<TareaViewModel> tareas)
        {
            using (StreamWriter writetext = new StreamWriter($@"{Directory.GetCurrentDirectory()}\tareas pendientes.txt", append: true))
            {
                foreach (var tarea in tareas)
                {
                    writetext.WriteLine($"{DateTime.Now.ToString().PadRight(25)}{tarea.Id.ToString().PadRight(10)}{tarea.NombreUsuario.PadRight(30)}{tarea.Title}");
                }
            }
        }
    }
}
