using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class _3DPoint:IComparable, ICloneable
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public _3DPoint() { }

        public _3DPoint(int X)
        {
            this.X = X;
        }

        public _3DPoint(int X, int Y) :this(X)
        {
            this.Y = Y;
        }

        public _3DPoint(int X, int Y, int Z) : this(X, Y)
        {
            this.Z = Z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public int CompareTo(object? obj)
        {
            _3DPoint? p = (_3DPoint?)obj;
            if (this.X > p.X)
                return 1;
            else if (this.Y > p.Y)
                return -1;
            return 0;
        }

        public object Clone()
        {
            return new _3DPoint()
            {
                X = this.X,
                Y = this.Y,
                Z = this.Z
            };
        }
    }
}
