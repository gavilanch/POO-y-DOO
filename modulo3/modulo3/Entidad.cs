using System;
using System.Collections.Generic;
using System.Text;

namespace modulo3
{
    public class Entidad
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }

    public class Persona : Entidad
    {
        public string Nombre { get; set; }
    }

    public class Producto : Entidad
    {
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
    }
}
