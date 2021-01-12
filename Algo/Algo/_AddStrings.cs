using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class _AddStrings
    {
        public string AddStrings(string num1, string num2)
        {
            StringBuilder sb = new StringBuilder("");
            int a = num1.Length - 1, b = num2.Length - 1, temp = 0, maxLength = 0, count = 0;

            if (num1.Length == 1 && num2.Length == 1)
                return (int.Parse(num1[a].ToString()) + int.Parse(num2[b].ToString())).ToString();

            if (num1.Length >= num2.Length) {
                maxLength = num1.Length - 1;
            }
            else {
                maxLength = num2.Length - 1;
            }

            while(count <= maxLength)
            {
                if (a > -1 && b > -1)
                {
                    sb.Insert(0, ((int.Parse(num1[a].ToString()) + int.Parse(num2[b].ToString()) + temp) % 10).ToString());

                    if (int.Parse(num1[a].ToString()) + int.Parse(num2[b].ToString()) + temp >= 10)
                    {
                        temp = (int.Parse(num1[a].ToString()) + int.Parse(num2[b].ToString()) + temp) / 10;
                    }
                    else temp = 0;
                }
                else
                {
                    if(a <= -1)
                    {
                        if (count < maxLength)
                        {
                            sb.Insert(0, ((int.Parse(num2[b].ToString()) + temp) % 10).ToString());
                        }
                        else sb.Insert(0, (int.Parse(num2[b].ToString()) + temp)).ToString();

                        if (int.Parse(num2[b].ToString()) + temp >= 10)
                        {
                            temp = (int.Parse(num2[b].ToString()) + temp) / 10;
                        }
                        else temp = 0;
                    }
                    else
                    {
                        if (count < maxLength)
                        {
                            sb.Insert(0, ((int.Parse(num1[a].ToString()) + temp) % 10).ToString());
                        }
                        else sb.Insert(0, (int.Parse(num1[a].ToString()) + temp)).ToString();

                        if (int.Parse(num1[a].ToString()) + temp >= 10)
                        {
                            temp = (int.Parse(num1[a].ToString()) + temp) / 10;
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

            if(num1.Length == num2.Length)
            {
                if(temp != 0)
                {
                    sb.Insert(0, temp);
                }
            }

            return sb.ToString();
        }
    }
}
