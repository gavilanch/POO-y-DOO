using System;

namespace Libreria
{

    public class ClienteDentroDeLibreria
    {
        public void Prueba()
        {
            var clasePublica = new ClasePublicaDePrueba();
            clasePublica.PropiedadInterna = "b";
            //clasePublica.MetodoPrivado(); // ERROR
            clasePublica.PropiedadProtectedInternal = "podemos";
            var claseInterna = new ClaseInternaDePrueba();
        }
    }

    public class ClasePublicaDePrueba
    {

        internal void MetodoRecibeClaseInterna(ClaseInternaDePrueba claseInterna)
        {

        }

        public int PropiedadPublica { get; set; }
        internal string PropiedadInterna { get; set; }
        protected int PropiedadProtegida { get; set; }
        protected internal string PropiedadProtectedInternal { get; set; }
        private protected int PropiedadPrivateProtected { get; set; }
        public void MetodoPublico()
        {
            PropiedadProtegida = 4;
            PropiedadInterna = "a";
            PropiedadPublica = 1;
            PropiedadProtectedInternal = "b";
            PropiedadPrivateProtected = 3;
            MetodoPrivado();
        }

        private void MetodoPrivado()
        {

        }

    }

    public class ClaseDerivada: ClasePublicaDePrueba
    {
        public void Prueba()
        {
            PropiedadPrivateProtected = 4;
        }
    }

    public class ClaseInternaDePrueba
    {

    }
}
