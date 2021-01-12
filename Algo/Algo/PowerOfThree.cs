using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class PowerOfThree
    {
        public bool IsPowerOfThree(int n)//Đệ quy tuyến tính
        {
            if (n == 0) return false;
            if (n == 1) return true;
            return n % 3 == 0 && IsPowerOfThree(n / 3);
        }
    }
}
