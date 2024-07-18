using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binding
{
    internal class TypeA
    {
        public int A {  get; set; }

        public TypeA() { }

        public TypeA(int a) {  A = a; }

        public void MyFun01()
        {
            Console.WriteLine("I'm base class.");
        }

        public virtual void MyFun02() 
        { 
            Console.WriteLine($"TypeA A: {A}"); 
        }
    }
}
