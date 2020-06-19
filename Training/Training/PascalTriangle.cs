using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class PascalTriangle
    {
        public IList<IList<int>> Generate(int numRows)//Xuất ra hình tam giác Pascal: Xem đề bài trên trang LeetCode (Pascal's Triangle)
        {
            IList<IList<int>> pascal = new List<IList<int>>();

            for (int i = 1; i <= numRows; i++)
            {
                pascal.Add(new int[i]);
            }

            for (int i = 0; i < pascal.Count; i++)
            {
                pascal[i][0] = 1;
                pascal[i][pascal[i].Count - 1] = 1;

                for (int j = 0; j < pascal[i].Count; j++)
                {
                    if(pascal[i][j] == 0)
                    {
                        pascal[i][j] = pascal[i - 1][j-1] + pascal[i - 1][j];
                    }
                }

            }
            return pascal;
        }
    }
}
