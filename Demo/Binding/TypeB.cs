using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binding
{
    internal class TypeB:TypeA
    {
        public int B { get; set; }

        public TypeB() { }
        public TypeB(int A, int B):base(A)
        { 
           this.B = B;
        }

        //static binding (early binding)
        //Compiler will bind function call based on reference not object
        // at compilation time
        public new void MyFun01()
        {
            Console.WriteLine("I'm Drivid class.");
        }

        //Dynamic binding (late binding)
        // Clr will bind function call based on object 
        // at run time
        public override void MyFun02()
        {
            Console.WriteLine($"TypeB A: {A}\nB: {B}");
        }
    }
}
