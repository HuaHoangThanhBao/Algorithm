using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            int index = 0;
            if (target > nums[nums.Length - 1]) index = nums.Length;
            else
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (target > nums[i] && target <= nums[i + 1])
                        index = i + 1;
                }
            }
            return index;
        }
    }
}
