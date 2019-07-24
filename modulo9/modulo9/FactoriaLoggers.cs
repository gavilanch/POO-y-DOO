using System;
using System.Collections.Generic;
using System.Text;

namespace modulo9
{
    public class FactoriaLoggers
    {
        public ILog ObtenerLogger(string discriminante)
        {
            switch (discriminante)
            {
                case "consola":
                    return new LoggerConsola();
                case "archivo":
                    return new LoggerArchivoDeTexto();
                default:
                    throw new NotImplementedException("logger not found");
            }
        }

    }
}
