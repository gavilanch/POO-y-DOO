using System;
using System.Collections.Generic;
using System.Text;

namespace modulo6
{
    public enum TipoAlerta
    {
        PorDefecto,
        Exito,
        Peligro,
        Error
    }


    public static class Alerta
    {

        public static void MostrarMensajeExitoso(string mensaje)
        {
            MostrarMensaje(mensaje, TipoAlerta.Exito);
        }

        public static void MostrarMensajePeligro(string mensaje)
        {
            MostrarMensaje(mensaje, TipoAlerta.Peligro);
        }

        public static void MostrarMensajeError(string mensaje)
        {
            MostrarMensaje(mensaje, TipoAlerta.Error);
        }


        private static void MostrarMensaje(string mensaje, TipoAlerta tipoMensaje)
        {
            var colorPorDefecto = ConsoleColor.White;
            switch (tipoMensaje)
            {
                case TipoAlerta.Exito:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case TipoAlerta.Peligro:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case TipoAlerta.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.ForegroundColor = colorPorDefecto;
                    break;
            }

            Console.WriteLine(mensaje);
            Console.ForegroundColor = colorPorDefecto;
        }
    }

}
