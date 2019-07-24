using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace modulo9
{
    public interface ILog
    {
        void Log(string mensaje);
        void LogException(Exception ex);
    }

    public class LoggerConsola : ILog
    {
        public void Log(string mensaje)
        {
            Console.WriteLine($"{DateTime.Now}: {mensaje}");
        }

        public void SetearColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public void LogException(Exception ex)
        {
            SetearColor(ConsoleColor.Red);
            string error = $"{ex.Message}: {ex.StackTrace}";
            Log(error);
            SetearColor(ConsoleColor.White);

        }

    }

    public class LoggerArchivoDeTexto : ILog
    {
        public void Log(string mensaje)
        {
            using (StreamWriter writetext = new StreamWriter(@"C:\log.txt", append: true))
            {
                writetext.WriteLine(mensaje);
            }
        }

        public void LogException(Exception ex)
        {
            string error = $"{ex.Message}: {ex.StackTrace}";
            Log(error);
        }
    }
}
