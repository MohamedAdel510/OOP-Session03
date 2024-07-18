using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binding
{
    internal class TypeD: TypeC
    {
        public int D { get; set; }

        public new void MyFun01() {
            Console.WriteLine("Iam Type D Class");
        }

        public new virtual void MyFun02()
        {
            Console.WriteLine($"Type D, A: {A}, B: {B}, C: {C}, D: {D}");
        }
    }
}
