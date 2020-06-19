using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class AddBinary
    {
        public string AddBinaryS(string a, string b)//Làm phép tính cộng nhị phân từ 2 chuỗi nhập vào
        {
            string result = "";
            Stack a_q = new Stack();
            Stack b_q = new Stack();
            Stack result_q = new Stack();

            for (int i = 0; i < a.Length; i++)
            {
                a_q.Push(a[i]);
            }

            for (int i = 0; i < b.Length; i++)
            {
                b_q.Push(b[i]);
            }

            int p_a, p_b, temp = 0;

            if(a.Length > b.Length)
            {
                while(b_q.Count != 0)
                {
                    p_a = int.Parse(a_q.Peek().ToString());
                    p_b = int.Parse(b_q.Peek().ToString());

                    if (p_a + p_b + temp == 2)
                    {
                        temp = 1;
                        result_q.Push("0");
                    }
                    else if (p_a + p_b + temp == 3)
                    {
                        temp = 1;
                        result_q.Push("1");
                    }
                    else
                    {
                        result_q.Push((p_a + p_b + temp).ToString());
                        temp = 0;
                    }
                    a_q.Pop();
                    b_q.Pop();
                }
                while(a_q.Count != 0)
                {
                    p_a = int.Parse(a_q.Peek().ToString());

                    if(p_a + temp == 2)
                    {
                        temp = 1;
                        result_q.Push("0");
                    }
                    else if (p_a + temp == 3)
                    {
                        temp = 1;
                        result_q.Push("1");
                    }
                    else
                    {
                        result_q.Push((p_a + temp).ToString());
                        temp = 0;
                    }

                    a_q.Pop();
                }
                if(a_q.Count == 0)
                {
                    if(temp == 1)
                    {
                        result_q.Push(1.ToString());
                    }
                }
            }
            else if(a.Length < b.Length)
            {
                while (a_q.Count != 0)
                {
                    p_a = int.Parse(a_q.Peek().ToString());
                    p_b = int.Parse(b_q.Peek().ToString());

                    if (p_a + p_b + temp == 2)
                    {
                        temp = 1;
                        result_q.Push("0");
                    }
                    else if (p_a + p_b + temp == 3)
                    {
                        temp = 1;
                        result_q.Push("1");
                    }
                    else
                    {
                        result_q.Push((p_a + p_b + temp).ToString());
                        temp = 0;
                    }
                    a_q.Pop();
                    b_q.Pop();
                }
                while (b_q.Count != 0)
                {
                    p_b = int.Parse(b_q.Peek().ToString());

                    if (p_b + temp == 2)
                    {
                        temp = 1;
                        result_q.Push("0");
                    }
                    else if (p_b + temp == 3)
                    {
                        temp = 1;
                        result_q.Push("1");
                    }
                    else
                    {
                        result_q.Push((p_b + temp).ToString());
                        temp = 0;
                    }

                    b_q.Pop();
                }
                if (b_q.Count == 0)
                {
                    if (temp == 1)
                    {
                        result_q.Push(1.ToString());
                    }
                }
            }
            else
            {
                while (a_q.Count != 0)
                {
                    p_a = int.Parse(a_q.Peek().ToString());
                    p_b = int.Parse(b_q.Peek().ToString());

                    if (p_a + p_b + temp == 2)
                    {
                        temp = 1;
                        result_q.Push("0");
                    }
                    else if (p_a + p_b + temp == 3)
                    {
                        temp = 1;
                        result_q.Push("1");
                    }
                    else
                    {
                        result_q.Push((p_a + p_b + temp).ToString());
                        temp = 0;
                    }
                    a_q.Pop();
                    b_q.Pop();
                }
                if(temp == 1)
                {
                    result_q.Push("1");
                }
            }

            while(result_q.Count != 0)
            {
                int num = int.Parse(result_q.Peek().ToString());
                result += num;
                result_q.Pop();
            }

            return result;
        }
    }
}
