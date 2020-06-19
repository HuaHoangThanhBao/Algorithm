using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class RemoveElement
    {
        public int Remove(int[] nums, int val)//Xóa những số trùng với số nhập vào (nhưng ko dc copy sang mảng khác)
        {
            int length = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == val || nums[i] == -1)//Nếu tìm thấy ô nào trùng với số nhập vào hoặc ô đã xóa thì disable ô đó
                {
                    nums[i] = -1;
                    for (int j = i + 1; j < nums.Length; j++)//Xét ô tiếp theo
                    {
                        if(nums[j] != -1 && nums[j] != val)
                        {
                            nums[i] = nums[j];
                            nums[j] = -1;
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            return length;
        }
    }
}
