using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class ContainsDuplicate
    {
        //Kiểm tra các ký tự trong mảng có bị lặp lại ko?
        //Bài này nếu dùng thuật toán thông thường chỉ chạy dc mảng khoảng 100 phần tử
        //Nếu dùng HashSet có thể duyệt tới 10 triệu phần tử (hoặc với tập dữ liệu lớn phức tạp)
        //HashSet không cho phép trùng giá trị
        public bool ContainsDuplicates(int[] nums)
        {
            return (new HashSet<int>(nums)).Count != nums.Length;
        }
    }
}
