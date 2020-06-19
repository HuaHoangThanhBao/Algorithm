using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class PowerOfTwo
    {
        //Tham khảo trên trang StackOverFlow
        public bool IsPowerOfTwo(int n)//Kiểm tra xem số n có phải là 1 số dc hình thành bởi 2^x hay ko? (VD: n=1, 2^0 = 1 => Đúng; n=15, 2^4 = 16 || 2^3 = 8 => Sai)
        {
            return (n > 0) && ((n & (n - 1)) == 0);
        }
    }
}
