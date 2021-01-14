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
            if (x >= Int32.MaxValue) return 0;
            if (x <= Int32.MinValue) return 0;

            double result = 0, length = 0;
            while (x != 0)
            {
                length = Math.Abs(x).ToString().Length - 1;
                result += (x % 10) * (Math.Pow(10, length));
                x /= 10;
            }

            return ((int)result == int.MaxValue || (int) result == int.MinValue)? 0: (int)(result);
        }
    }
}
