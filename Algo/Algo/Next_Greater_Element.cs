using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class Next_Greater_Element
    {
        //Bài khó
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var outputArr = new int[nums1.Length];
            var calcDict = new Dictionary<int, int>();
            var myStack = new Stack<int>();
            for (int i = nums2.Length - 1; i >= 0; i--)
            {
                while (myStack.Count > 0 && nums2[i] > myStack.Peek())
                {
                    myStack.Pop();
                }
                calcDict.Add(nums2[i], myStack.Count > 0 ? myStack.Peek() : -1);
                myStack.Push(nums2[i]);
            }
            int j = 0;
            foreach (int num in nums1)
            {
                outputArr[j] = calcDict[num];
                j++;
            }
            return outputArr;
        }
    }
}
