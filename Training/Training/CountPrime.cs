using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class CountPrime
    {
        //Bài nâng cao của tìm số nguyên tố với tập số lớn
        public int CountPrimes(int n)//Tìm số nguyên tố bé hơn số nhập vào
        {
            int num = 0;
            for (int i = 2; i < n; i++)
            {
                int count = 0;
                for (int j = 2; j <= Math.Sqrt(i); j++)//Chú ý chỗ SQRT => dùng cho những tập số lớn như: 445478
                {
                    if(i % j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if(count == 0)
                {
                    num++;
                }
            }
            return num;
        }
    }
}
