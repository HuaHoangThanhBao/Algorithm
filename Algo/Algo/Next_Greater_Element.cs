using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class Next_Greater_Element
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            //Chưa giải xong bài này
            int cur = 0;
            int next_index = 0;
            int cur_index = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                cur_index = nums2.ToList().IndexOf(nums1[i]);
                next_index = cur_index + 1;
                if (next_index < nums2.Length)
                {
                    if (nums2[next_index] > nums1[i])
                        nums1[i] = nums2[next_index];
                    else nums1[i] = -1;
                }
                else nums1[i] = -1;
            }
            return nums1;
        }
    }
}
