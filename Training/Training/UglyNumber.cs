using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class UglyNumber
    {
        //Ugly Number: là 1 số nguyên dương mà các thành phần con của nó chia hết cho 1 trong 3 số nguyên tố 2, 3, 5
        public bool IsUgly(int num)//Kiểm tra số nhập vào có phải ugly number hay không?
        {
            int divide = 0;
            bool found = true;

            if (num == 1) return true;
            if (num == 0) return false;
            if (num < 0) return false;

            while(num > 1)
            {
                if(num % 2 == 0)
                {
                    divide = 2;
                }
                
                if(num % 3 == 0)
                {
                    divide = 3;
                }
                
                if (num % 5 == 0)
                {
                    divide = 5;
                }

                if (divide != 0)
                {
                    num /= divide;
                    divide = 0;
                }
                else
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
