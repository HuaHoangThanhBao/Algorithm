using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class HouseRobber
    {
        public int Rob(int[] nums)
        {
            int n = nums.Length;
            if (n == 0) return 0;
            int a = 0, b = 0;
            a = nums[0];
            b = 0;
            for (int i = 1; i < n; i++)
            {
                int c = nums[i] + b;
                b = max(a, b);
                a = c;
            }
            return max(a, b);
        }

        public int max (int a, int b)
        {
            if (a > b) return a;
            else return b;
        }
    }
}
