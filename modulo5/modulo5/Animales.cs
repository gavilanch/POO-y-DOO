using System;
using System.Collections.Generic;
using System.Text;

namespace modulo5
{
    public abstract class Animal
    {
        public abstract void HacerRuido();
    }

    public class Perro : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("auf auf");
        }
    }

    public class Gato : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("miau");
        }
    }


}
