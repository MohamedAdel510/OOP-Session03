using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binding
{
    internal class TypeE:TypeD
    {
        public int E {  get; set; }

        public new void MyFun01() {
            Console.WriteLine(" Iam Class E.");
        }

        public override void MyFun02()
        {
            Console.WriteLine($"Type E, A: {A}, B: {B}, C: {C}, D: {D}, E: {E}");
        }
    }
}
