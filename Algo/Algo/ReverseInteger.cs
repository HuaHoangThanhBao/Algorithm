using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            if (x == 0) return 0;

            int mod = Math.Abs(x);
            if (mod < Int32.MinValue || mod > Int32.MaxValue - 1) return 0;

            int result = 0;
            int pos = mod.ToString().Length;

            while(mod != 0)
            {
                if (mod / 10 != 0)
                    result += (mod % 10) * Convert.ToInt32((Math.Pow(10, pos - 1)));
                else result += mod % 10;

                pos--;
                mod /= 10;
            }

            if (x > 0)
                return result;
            else return -result;
        }
    }
}
