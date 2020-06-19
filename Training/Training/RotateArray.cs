using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class RotateArray
    {
        //Tham khảo đề trang leetcode
        public void Rotate(int[] nums, int k)//đưa số cuối lên đầu mảng với k là số lần đưa lên
        {
            int last = 0;
            for (int i = 0; i < k; i++)
            {
                last = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j > 0; j--)//Cập nhật số trước bằng số sau (đẩy mảng về sau)
                {
                    nums[j] = nums[j - 1];
                }
                nums[0] = last;
            }
        }
    }
}
