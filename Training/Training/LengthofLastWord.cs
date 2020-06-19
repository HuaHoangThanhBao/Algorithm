using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class LengthofLastWord
    {
        public int LengthOfLastWord(string s)//Tính độ dài của từ cuối cùng trong chuỗi
        {
            string[] arr = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return arr.Length != 0 ? arr[arr.Length - 1].Length : 0;
        }
    }
}
