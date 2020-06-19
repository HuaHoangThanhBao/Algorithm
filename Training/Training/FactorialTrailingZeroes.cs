using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class FactorialTrailingZeroes
    {
        //Bài này khó nếu dùng với số lớn, số nhỏ có thể dùng thuật toán khác dễ hơn
        public int TrailingZeroes(int n)//Đếm các số 0 cuối cùng của số giai thừa (VD: 3! = 6 => 0 có số 0 cuối, 30! => 7 số 0 cuối)
        {
            int count = 0;
            for (long i = 5; i <= n; i *= 5)
                count += (int)(n / i);
            return count;
        }
    }
}
