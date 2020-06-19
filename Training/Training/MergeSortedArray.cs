using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)//Chưa làm xong
        {
            int count = nums1.Length - 1;

            int i = m - 1;
            int j = n - 1;
            while(i >= 0 && j >= 0)
            {
                if(nums2[i] > nums1[j])
                {
                    nums1[count] = nums2[j];
                    j--;
                }
                else
                {
                    nums1[count] = nums2[i];
                    i--;
                }
                count--;
            } 
            while (j >= 0)
            {
                nums1[count] = nums2[j];
                j--;
                count--;
            }
            foreach (var item in nums1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
