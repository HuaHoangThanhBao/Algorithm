using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class _MajorityElement
    {
        //Bài quan trọng
        public int MajorityElement(int[] nums)
        {
            int major = 0, count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == major) count++;
                else if (count == 0)
                {
                    major = nums[i];
                    count++;
                }
                else count--;
            }
            return major;
        }
    }
}
