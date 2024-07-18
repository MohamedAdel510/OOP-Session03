using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binding
{
    internal class PartTimeEmployee:Employee
    {
        public decimal HourRate { get; set; }

        public new void MyFun01()
        {
            Console.WriteLine("Iam a Part Time Employee.");

        }

        public override void MyFun02()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}, Hour Rate: {HourRate}");
        }
    }
}
