using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface
{
    internal class SeriesByFour : ISeries
    {
        public int Current { get ; set  ; }

        public void GetNext()
        {
            this.Current += 4;
        }

        public void Reset()
        {
            this.Current = 0;
        }
    }
}
