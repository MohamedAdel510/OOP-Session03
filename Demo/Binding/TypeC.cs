using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binding
{
    internal class TypeC:TypeB
    {
        public int C { get; set; }

        public new void MyFun01()
        {
            Console.WriteLine("Iam drived class [grand child].");
        }

        public override void MyFun02()
        {
            Console.WriteLine($"TypeC A:{A}, B:{B}, C:{C}");
        }
    }
}
