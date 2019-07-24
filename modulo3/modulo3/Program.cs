using System;

namespace modulo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal perro = new Perro("Felipe");
            //ProcesarAnimal(perro);
            //ProcesarAnimal(new Gato());
        }

        static void ProcesarAnimal(Animal animal)
        {
            animal.HacerRuido();
        }
    }


    public abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("Constructor de la clase animal");
        }

        public Animal(string param)
        {
            Console.WriteLine($"{param} en la clase animal");
        }

        //public abstract void HacerRuido();
        public virtual void HacerRuido()
        {
            Console.WriteLine("hacer ruido genérico");
        }
    }

    public class Perro : Animal
    {
        public Perro()
        {
            Console.WriteLine("Constructor de la clase Perro");
        }

        public Perro(string param1)
            :base(param1)
        {
            Console.WriteLine("Constructor de la clase perro con parámetro");
        }
        public override void HacerRuido()
        {
            Console.WriteLine("auf auf");
        }
    }

    public class Gato : Animal
    {
        
    }


}
