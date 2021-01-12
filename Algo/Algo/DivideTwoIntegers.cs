using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class DivideTwoIntegers
    {
        public int Divide(int dividend, int divisor)
        {
            int count = 0;
            int num = 1;

            int left = Math.Abs(dividend);
            int right = Math.Abs(divisor);

            if (left < right) return 0;
            else if (left == right)
            {
                if ((dividend < 0 && divisor < 0) || (dividend > 0 && divisor > 0))
                    return 1;
                else return -1;
            }

            while (num < left)
            {
                count++;
                num = right * count;
                if (num + right > left) break;
            }

            if ((dividend < 0 && divisor < 0) || (dividend > 0 && divisor > 0))
                return count;
            else return -count;
        }
    }
}
