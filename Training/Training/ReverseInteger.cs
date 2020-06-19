using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class ReverseInteger
    {
        public int Reverse(int x)//Bài toán đảo chuỗi
        {
            int rev = 0;//Khai báo biến tổng
            while (x != 0)
            {
                rev = rev * 10 + x % 10;
                x /= 10;//Chia tiếp số x (lấy phần nguyên)
            }
            return rev;
        }
    }
}
