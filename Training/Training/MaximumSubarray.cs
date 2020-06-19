using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class MaximumSubarray
    {
        //Cách này dùng dc nhưng ko hiệu quả: O(n^2)
        //public int MaxSubArray(int[] nums)
        //{
        //    int sum = 0, max = -Int32.MaxValue;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        sum += nums[i];
        //        if (sum > max)
        //        {
        //            max = sum;
        //        }
        //        for (int j = i+1; j < nums.Length; j++)
        //        {
        //            sum += nums[j];
        //            if (sum > max)
        //            {
        //                max = sum;
        //            }
        //        }
        //        sum = 0;
        //    }
        //    return max;
        //}

        //Cách này dùng tốt: O(n)
        public int maxCrossingSum(int[] arr, int l,
                            int m, int h)
        {
            // Include elements on left of mid. 
            int sum = 0;
            int left_sum = int.MinValue;
            for (int i = m; i >= l; i--)
            {
                sum = sum + arr[i];
                if (sum > left_sum)
                    left_sum = sum;
            }

            // Include elements on right of mid 
            sum = 0;
            int right_sum = int.MinValue;
            for (int i = m + 1; i <= h; i++)
            {
                sum = sum + arr[i];
                if (sum > right_sum)
                    right_sum = sum;
            }

            // Return sum of elements on left 
            // and right of mid 
            // returning only left_sum + right_sum will fail for [-2, 1] 
            return Math.Max(left_sum + right_sum, Math.Max(left_sum, right_sum));
        }

        // Returns sum of maxium sum subarray  
        // in aa[l..h] 
        public int MaxSubArray(int[] arr, int l,
                                            int h)
        {

            // Base Case: Only one element 
            if (l == h)
                return arr[l];

            // Find middle point 
            int m = (l + h) / 2;

            /* Return maximum of following three  
            possible cases: 
            a) Maximum subarray sum in left half 
            b) Maximum subarray sum in right half 
            c) Maximum subarray sum such that the  
            subarray crosses the midpoint */
            return Math.Max(Math.Max(MaxSubArray(arr, l, m),
                                  MaxSubArray(arr, m + 1, h)),
                                 maxCrossingSum(arr, l, m, h));
        }
    }
}
