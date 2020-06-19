using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class PascalTriangleII
    {
        public IList<int> GetRow(int rowIndex)//Lấy dòng trong tam giác với địa chỉ dòng truyền vào sau khi đã tính dc các số tam giác
        {
            IList<int> result = new List<int>();
            IList<IList<int>> pascal = new List<IList<int>>();

            result.Add(1);

            for (int i = 1; i <= rowIndex + 1; i++)
            {
                pascal.Add(new int[i]);
            }

            for (int i = 0; i < pascal.Count; i++)
            {
                pascal[i][0] = 1;
                pascal[i][pascal[i].Count - 1] = 1;

                for (int j = 0; j < pascal[i].Count; j++)
                {
                    if (pascal[i][j] == 0)
                    {
                        pascal[i][j] = pascal[i - 1][j - 1] + pascal[i - 1][j];
                        if (i == rowIndex)
                        {
                            result.Add(pascal[i][j]);
                        }
                    }
                }
            }

            if (rowIndex != 0)
                result.Add(1);

            return result;
        }
    }
}
