using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo2
{
    public static class UtilidadesDeFechas
    {
        public static int CalcularEdad(this DateTime fechaNacimiento, string param2)
        {
            var edad = DateTime.Today.Year - fechaNacimiento.Year;
            var temp = new DateTime(DateTime.Today.Year,
                       fechaNacimiento.Month, fechaNacimiento.Day);

            if (temp > DateTime.Today)
            {
                edad--;
            }
            return edad;

        }
    }

    public static class UtilidadesDeStrings
    {
        public static int ContarVocales(this string valor)
        {
            if (valor == null)
            {
                throw new ArgumentException("El parámetro no puede ser nulo");
            }

            var resultado = 0;
            var vocales = "aeiou";
            valor = valor.ToLower();

            foreach (var caracter in valor)
            {
                if (vocales.Contains(caracter))
                {
                    resultado++;
                }
            }

            return resultado;
        }
    }
}
