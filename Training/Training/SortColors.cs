using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class SortColors
    {
        //Dùng thuật toán selection sort
        public void SortColor(int[] nums)//Sắp xếp màu theo thứ tự tăng dần
        {
            int n = nums.Length;
            int temp, smallest;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[j] < nums[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = nums[smallest];
                nums[smallest] = nums[i];
                nums[i] = temp;
            }
        }
    }
}
