using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class Max_Consecutive_Ones
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int cur = 0;
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    cur++;
                    if (cur > max) max = cur;
                }
                else
                {
                    cur = 0;
                }
            }
            return max;
        }
    }
}
