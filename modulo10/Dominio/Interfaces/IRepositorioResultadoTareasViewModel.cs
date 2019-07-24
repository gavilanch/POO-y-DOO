using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Interfaces
{
    public interface IRepositorioResultadoTareasViewModel
    {
        void Guardar(List<TareaViewModel> tareas);
    }
}
