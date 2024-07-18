using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface
{
    internal interface IMyType
    {
        // Interface is a completly abstracted class which can only contain:
        // 1- Signature for property
        int Salary {  get; set; }

        // 2- Signature for method
        void MyFun();

        // 3- Default implemented method
        void Print()
        {
            Console.WriteLine("Default implemented method.");
        }
    }
}
