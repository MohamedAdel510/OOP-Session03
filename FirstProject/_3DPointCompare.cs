using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class _3DPointCompare : IComparer
    {
        public int Compare(object? x, object? y)
        {
            _3DPoint? PX = (_3DPoint?)x;
            _3DPoint? PY = (_3DPoint?)y;
            return PX?.Y.CompareTo(PY?.Y) ?? (PY is null ? 0 : -1);
        }
    }
}
