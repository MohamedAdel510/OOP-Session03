using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface
{
    internal class MyType : IMyType
    {
        public int Salary { get ; set ; }

        public void MyFun()
        {
            Console.WriteLine("Implemetation for method");
        }
    }
}
