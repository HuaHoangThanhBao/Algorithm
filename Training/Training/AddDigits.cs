using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class AddDigits
    {
        //Xem đề bài trên trang leetcode (Add Digits)
        public int AddDigit(int num)
        {
            int result = num;
            int a, b;
            while(result >= 10)
            {
                a = num / 10;
                b = num % 10;
                if (a + b < 10)
                {
                    result = a + b;
                    break;
                }
                else
                {
                    num = a + b;
                }
            }
            return result;
        }
    }
}
