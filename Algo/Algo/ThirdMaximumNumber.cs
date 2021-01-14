using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class ThirdMaximumNumber
    {
        public int ThirdMax(int[] nums)
        {
            int i; int [] c = new int[nums.Length]; int k = 0;
            Array.Sort(nums);
            for (i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1)
                {
                    c[k++] = nums[i]; break;
                }
                else if (nums[i] != nums[i + 1])
                    c[k++] = nums[i];

            }
            if (k == 1)
                return (c[0]);
            else if (k == 2)
                return (c[1]);
            else
                return (c[k - 3]);
            //Array.Sort(nums);
            //return nums.Length >= 3 ? nums[nums.Length - 3] : nums[nums.Length - 1];
        }
    }
}
