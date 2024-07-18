using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface.Example03
{

    internal class Car : Vechile, Imovable
    {
        public void Backword()
        {
            Console.WriteLine("Car Move Backword.");
        }

        public void Forword()
        {
            Console.WriteLine("Car Move Forword.");
        }

        public void Left()
        {
            Console.WriteLine("Car Move Left.");
        }

        public void Right()
        {
            Console.WriteLine("Car Move Rigth.");
        }
    }
}
