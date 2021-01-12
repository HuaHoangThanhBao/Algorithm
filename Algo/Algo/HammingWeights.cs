using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class HammingWeights
    {
        public int HammingWeight(uint n)
        {
            int count = 0;
            while (n != 0)
            {
                n = n & (n - 1);//Cách tính nhị phân: lấy phần chung của 2 bit: n và (n-1)
                count++;
            }
            return count;
        }
    }
}
