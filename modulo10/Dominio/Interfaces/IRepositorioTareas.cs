using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IRepositorioTareas
    {
        Task<List<Tarea>> ObtenerTareas();
    }
}
