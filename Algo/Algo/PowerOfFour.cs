using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class PowerOfFour
    {
        public bool IsPowerOfFour(int num)
        {
            if (num == 0) return false;
            if (num == 1) return true;
            return num % 4 == 0 && IsPowerOfFour(num / 4);
        }
    }
}
