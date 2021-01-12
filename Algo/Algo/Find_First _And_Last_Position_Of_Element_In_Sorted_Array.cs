using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class Find_First__And_Last_Position_Of_Element_In_Sorted_Array
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int[] result = new int[2];
            int pos = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == target)
                {
                    if (pos == 0)
                    {
                        result[0] = i; 
                        result[1] = i;
                    }
                    else result[1] = i;

                    pos = 1;
                }
            }
            if (pos == 0) result = new int[] { -1, -1 };

            return result;
        }
    }
}
