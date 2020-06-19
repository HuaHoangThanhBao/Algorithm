using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class SingleOne
    {
        //Cách 1: đơn giản nhưng ko nhanh bằng cách 2
        public int SingleNumber(int[] nums)//Tìm ra số duy nhất trong mảng mà ko bị trùng
        {
            List<int> steps = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!steps.Contains(nums[i]))
                {
                    steps.Add(nums[i]);
                }
                else steps.Remove(nums[i]);
            }

            return steps[0];
        }

        /*Cách 2
        public int SingleNumber(int[] nums)//Tìm ra số duy nhất trong mảng mà ko bị trùng
        {
            int res = 0;
            foreach (var num in nums)
            {
                res ^= num;
            }
            return res;
        }
        */
    }
}
