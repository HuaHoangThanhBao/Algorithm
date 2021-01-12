using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class _3Sum
    {
        //Bài khó
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>();
            if (nums == null) return list;

            Array.Sort(nums);

            int left = 0, right = 0, three_sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                left = i + 1;
                right = nums.Length - 1;
                while(left < right)
                {
                    three_sum = nums[i] + nums[left] + nums[right];
                    if(three_sum > 0)
                    {
                        right--;
                    }
                    else if(three_sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        list.Add(new List<int> { nums[i], nums[left], nums[right] });
                        left++;
                        while(nums[left] == nums[left - 1] && left < right)
                        {
                            left++;
                        }
                    }
                }
            }
            return list;
        }
    }
}
