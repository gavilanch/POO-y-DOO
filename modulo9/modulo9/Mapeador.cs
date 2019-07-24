using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace modulo9
{
    public class Mapeador
    {
        public List<TareaViewModel> Mapear(List<Tarea> tareas, List<Usuario> usuarios)
        {
            var tareasViewModel = new List<TareaViewModel>();
            foreach (var tarea in tareas)
            {
                var tareaViewModel = new TareaViewModel()
                {
                    Id = tarea.Id,
                    Title = tarea.Title.Trim(),
                    NombreUsuario = usuarios.Where(x => x.Id == tarea.UserId).First().Name.Trim()
                };
                tareasViewModel.Add(tareaViewModel);
            }
            return tareasViewModel;
        }
    }

}
