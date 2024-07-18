using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface
{
    internal class SeriesByThree : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            this.Current += 3;
        }

        public void Reset()
        {
            this.Current = 0;
        }
    }
}
