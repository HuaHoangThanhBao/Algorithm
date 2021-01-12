using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class _AddToArrayForm
    {
        public IList<int> AddToArrayForm(int[] A, int K)
        {
            IList<int> result = new List<int>();
            string strK = K.ToString();
            int a = A.Length - 1, b = strK.Length - 1, temp = 0, maxLength = 0, count = 0;

            if (A.Length == 1 && K.ToString().Length == 1)
            {
                result.Insert(0, (A[a] + int.Parse(strK[b].ToString())));
                return result;
            }

            if (A.Length >= strK.Length)
            {
                maxLength = A.Length - 1;
            }
            else
            {
                maxLength = strK.Length - 1;
            }

            while (count <= maxLength)
            {
                if (a > -1 && b > -1)
                {
                    result.Insert(0, ((A[a] + int.Parse(strK[b].ToString()) + temp) % 10));

                    if (A[a] + int.Parse(strK[b].ToString()) + temp >= 10)
                    {
                        temp = (A[a]+ int.Parse(strK[b].ToString()) + temp) / 10;
                    }
                    else temp = 0;
                }
                else
                {
                    if (a <= -1)
                    {
                        if (count < maxLength)
                        {
                            result.Insert(0, ((int.Parse(strK[b].ToString()) + temp) % 10));
                        }
                        else
                        {
                            if (int.Parse(strK[b].ToString()) + temp > 10)
                                result.Insert(0, (int.Parse(strK[b].ToString()) + temp));
                            else if (int.Parse(strK[b].ToString()) + temp == 10)
                            {
                                result.Insert(0, 0);
                                result.Insert(0, 1);
                            }
                            else
                                result.Insert(0, (int.Parse(strK[b].ToString()) + temp));
                        }

                        if (int.Parse(strK[b].ToString()) + temp >= 10)
                        {
                            temp = (int.Parse(strK[b].ToString()) + temp) / 10;
                        }
                        else temp = 0;
                    }
                    else
                    {
                        if (count < maxLength)
                        {
                            result.Insert(0, ((A[a] + temp) % 10));
                        }
                        else
                        {
                            if (A[a] + temp > 10)
                                result.Insert(0, (A[a] + temp));
                            else if (A[a] + temp == 10)
                            {
                                result.Insert(0, 0);
                                result.Insert(0, 1);
                            }
                            else
                                result.Insert(0, (A[a] + temp));
                        }

                        if (A[a] + temp >= 10)
                        {
                            temp = (A[a] + temp) / 10;
                        }
                        else temp = 0;
                    }
                }

                a--;
                b--;
                count++;

                if (a < 0) a = -1;
                if (b < 0) b = -1;
            }

            if (A.Length == strK.Length)
            {
                if (temp != 0)
                {
                    result.Insert(0, temp);
                }
            }

            return result;
        }
    }
}
