using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class MinMove
    {
        public int MinMoves(int[] nums)
        {
            int max = nums.Max();
            int cur_pos = Array.IndexOf(nums, max);
            int move = 0;
            while(nums.Any(m => m != nums[0]))
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j != cur_pos)
                    {
                        nums[j]++;
                    }
                }
                move++;
                max = nums.Max();
                cur_pos = Array.IndexOf(nums, max);
            }
            return move;
        }
    }
}
