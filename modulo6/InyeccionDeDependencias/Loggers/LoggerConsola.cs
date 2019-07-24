using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace InyeccionDeDependencias.Loggers
{

    public interface IMiLogger
    {
        void Log(string mensaje);
    }

    public class LoggerConsola: IMiLogger
    {
        public void Log(string mensaje)
        {
            Debug.WriteLine($"{DateTime.Now}: {mensaje}");
        }
    }

    public class LoggerEnArchivo : IMiLogger
    {
        public void Log(string mensaje)
        {
            using (StreamWriter writetext = new StreamWriter($@"{Directory.GetCurrentDirectory()}\log.txt", append: true))
            {
                writetext.WriteLine($"{DateTime.Now}: {mensaje}");
            }
        }
    }


}
