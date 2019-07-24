using System;
using System.Collections.Generic;
using System.Text;

namespace modulo5
{
    /* Ejemplo de suma:
            var vector1 = new Vector(new int[] { 1, 4 });
            var vector2 = new Vector(new int[] { 2, 5 });
            var vectorSuma = vector1 + vector2;
         */
    public class Vector
    {
        public Vector(int[] valores)
        {
            vector = valores;
        }

        private int[] vector { get; set; }
        public int Dimension { get { return vector.Length; } }

        public int this[int i]
        {
            get { return vector[i]; }
            set { vector[i] = value; }
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return Sumar(v1, v2);
        }

        public static Vector Sumar(Vector vector1, Vector vector2)
        {
            // Sumar los vectores
            if (vector1.Dimension != vector2.Dimension)
            {
                throw new ApplicationException("No puedes sumar vectores de dimensiones distintas");
            }

            int[] resultado = new int[vector1.Dimension];
            for (int i = 0; i < vector1.Dimension; i++)
            {
                resultado[i] = vector1[i] + vector2[i];
            }

            var vectorSuma = new Vector(resultado);
            return vectorSuma;
        }

    }
}
