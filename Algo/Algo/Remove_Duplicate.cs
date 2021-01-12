using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class Remove_Duplicate
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 2) return nums.Length;
            int pos = 0, i = 0;
            for (i = 0; i < nums.Length; i++)
            {
                if(nums[pos] != nums[i])
                {
                    nums[pos + 1] = nums[i];
                    pos++;
                }
            }
            return pos + 1;
        }
    }
}
