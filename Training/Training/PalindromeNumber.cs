using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class PalindromeNumber
    {
        public bool IsPalindrome(int x)//Bài toán kiểm tra số khi đọc ngược giống với số ban đầu (VD: 121, ngược 121 > True, 123, ngược 321 > False)
        {
            int number = x, rev = 0;

            if (x < 0 || (x % 10 == 0 && x != 0))//Xét TH đặc biệt
                return false;

            while(number != 0)//Đảo chuỗi
            {
                rev = rev * 10 + number % 10;
                number /= 10;
                //Console.WriteLine(number + "/" + rev);
            }
            return x == rev;//Xét số sau khi đảo có giống số ban đầu ko?
        }
    }
}
