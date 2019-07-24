using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Interfaces
{
    public interface ILog
    {
        void Log(string mensaje);
        void LogException(Exception ex);
    }
}
