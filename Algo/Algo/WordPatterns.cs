using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class WordPatterns
    {
        //Kiểm tra xem chuỗi str nhập vào có hình thức thể hiện giống chuỗi pattern cho sẵn ko?
        public bool WordPattern(string pattern, string str)
        {
            //Split str to array which has childs to compare with pattern string
            //If they are different you can infer to the str does not follow the same pattern
            string[] copy = str.Split(' ');

            //If pattern length != str length => not follow pattern
            if (pattern.Length == copy.Length)
            {
                int p_count = 0, s_count = 0;//Counting occurencies of pattern and str
                int p_dif = 0, s_dif = 0;//Counting differences of pattern and str
                for (int i = 0; i < pattern.Length; i++)
                {
                    for (int j = i + 1; j < pattern.Length; j++)
                    {
                        //Compare if pattern at i and j position that have same value
                        if (pattern[j] == pattern[i])
                        {
                            //Plus occurencies of pattern
                            p_count++;
                            //Compare if copy array at i and j position that have same value
                            if (copy[j] == copy[i])
                            {
                                // Plus occurencies of str
                                s_count++;
                            }
                        }
                        else
                        {
                            // Plus differences of pattern
                            p_dif++;
                            //If copy array at i != j
                            if (copy[j] != copy[i])
                            {
                                // Plus differences of str
                                s_dif++;
                            }
                        }
                    }
                }
                //If occurencies equal to differences => you can conclude the str follow the same pattern
                if (p_count == s_count && p_dif == s_dif)
                    return true;
                else return false;
            }
            else return false;
        }
    }
}
