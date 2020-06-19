using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class PlusOne
    {
        public int[] PlusOneS(int[] digits)//Cộng 1 số vào chuỗi và xuất ra chuỗi mới (Khó)
        {
            List<int> arr = new List<int>();
            int temp = 1;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int num_plus = digits[i] + temp;
                if(num_plus >= 10)
                {
                    temp = 1;
                    digits[i] = 0;
                    arr.Add(digits[i]);
                }
                else
                {
                    temp = 0;
                    digits[i] = num_plus;
                    arr.Add(digits[i]);
                }
                if(i == 0)
                {
                    if(temp == 1)
                    {
                        arr.Add(1);
                    }
                }
            }

            int[] ar = new int[arr.Count];
            int count = ar.Length - 1;
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = arr[count];
                count--;
            }

            return ar;
        }
    }
}
