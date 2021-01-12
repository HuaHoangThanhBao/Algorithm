using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class Search_In_Rotated_Sorted_Array
    {
        public int Search(int[] nums, int target)
        {
            int pos = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == target)
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }
    }
}
