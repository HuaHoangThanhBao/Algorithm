using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class ClimbingStairs
    {
        public int ClimbStairs(int n)//Tìm tất cả các cách có thể cộng 1 và 2 để cho ra số nhập vào (chỉ cộng 1 và 2)
        {
            if (n <= 0) return 0;
            int x = 1, y = 1, k = 0, j = 1;
            for (int i = 0; i < n - 1; i++)
            {
                x = y;
                y = k;
                k = x + y;
                j += k;
            }
            return (j);
        }
    }
}
