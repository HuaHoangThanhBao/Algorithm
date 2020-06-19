﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class SetMatrixZeroes
    {
        public void SetZeroes(int[][] matrix)//Đọc trong ma trận tìm vị trí của số 0 và set tất cả các số theo hàng và cột tại vị trí đó = 0
        {
            int n = matrix.Length, m = matrix[0].Length;
            bool firstrow = false, firstcol = false;
            for (int i = 0; i < n; i++)
            {
                if (matrix[i][0] == 0)
                    firstcol = true;
            }
            for (int j = 0; j < m; j++)
            {
                if (matrix[0][j] == 0)
                    firstrow = true;
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[i][0] = matrix[0][j] = 0;
                    }
                }
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    if (matrix[i][0] == 0 || matrix[0][j] == 0)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
            if (firstrow)
            {
                for (int j = 0; j < m; j++)
                    matrix[0][j] = 0;
            }
            if (firstcol)
            {
                for (int i = 0; i < n; i++)
                    matrix[i][0] = 0;
            }
        }
    }
}
