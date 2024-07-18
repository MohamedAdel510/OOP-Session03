using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        Duration() { }
        public Duration(int Hours, int Minutes, int Seconds)
        {
            this.Hours = Hours;
            this.Minutes = Minutes;
            this.Seconds = Seconds;
        }
        
        public Duration(int Seconds)
        {
            this.Hours = Seconds / 3600;
            int remin = Seconds % 3600;
            this.Minutes = remin / 60;
            this.Seconds = remin % 60;
        }

        public override string ToString()
        {
            return $"Hours: {this.Hours}, Minutes: {this.Minutes}, Secondes: {this.Seconds}";
        }

        public override bool Equals(object? obj)
        {
            Duration? duration = (Duration?)obj;
            if(this == duration)return true ;
            return false ;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static Duration operator +(Duration D1,  Duration D2)
        {
            Duration D3 = new Duration();
            
            D3.Hours = D1.Hours + D2.Hours;
            D3.Minutes = D1.Minutes + D2.Minutes;
            D3.Seconds = D1.Seconds + D2.Seconds;
            return D3;
        }
        
    }
}
