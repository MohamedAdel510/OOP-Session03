using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface.Example03
{
    internal class AirPlan : Vechile, Imovable, IFlyable
    {
        // implementing interfaces implicitly if they have the same implementation

        // implementing interfaces explicitly
        void Imovable.Backword()
        {
            Console.WriteLine("Airplan Moves Backword.");
        }

        void IFlyable.Backword()
        {
            Console.WriteLine("Airplan Fly Backword.");
        }

        void Imovable.Forword()
        {
            Console.WriteLine("Airplan Moves Forword.");
        }

        void IFlyable.Forword()
        {
            Console.WriteLine("Airplan Fly Forword.");
        }

        void Imovable.Left()
        {
            Console.WriteLine("Airplan Moves Left.");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("Airplan Fly Left.");
        }

        void Imovable.Right()
        {
            Console.WriteLine("Airplan Moves Right.");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("Airplan Fly Right.");
        }

    }
}
