using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binding
{
    internal class FullTimeEmployee:Employee
    {
        public decimal Salary {  get; set; }

        public new void MyFun01()
        {
            Console.WriteLine("Iam a Full Time Employee.");
        }

        public override void MyFun02()  
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}");
        }
    }
}
