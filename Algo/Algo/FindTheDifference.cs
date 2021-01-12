using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class FindTheDifference
    {
        //Tìm số được thêm vào chuỗi khi so với s (VD: s = "abc", t = "acbb" => số dc thêm vào là b)
        public char FindTheDifferences(string s, string t)
        {
            List<char> a = s.ToList();
            List<char> b = t.ToList();
            a.Sort(); 
            b.Sort();
            //Ta sort lại list để tìm phần tử dc thâm vào 
            //(vì khi sort thì chắc chắn các số sẽ dc sắp xếp ta có thể nhận biết số nào khác trong mảng)
            for (int j = 0; j < s.Length; j++)
            {
                if (a[j] != b[j]) return b[j];
            }
            //Nếu duyệt hết s mà ko có số nào thì ta lấy phần tử cuối cùng bên t
            return b[b.Count() - 1];
        }
    }
}
