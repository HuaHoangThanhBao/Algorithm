using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class SquareNumber
    {
        //Gia3i thích: Số chính phương hay còn gọi là số hình vuông là số tự nhiên có căn bậc 2 là một số tự nhiên
        public bool isSquareNumber(int n)//Kiểm tra số chính phương
        {
            int num;
            if (int.TryParse(Math.Sqrt(n).ToString(), out num))//Nếu căn bậc 2 là số tự nhiên thì n là số chính phương
            {
                return true;
            }
            else return false;
        }
    }
}
