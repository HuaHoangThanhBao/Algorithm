using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class IsomorphicStrings
    {
        //ktra 2 chuỗi nhập vào có đẳng cấu hay ko? (VD: abba, abab => 0 đẳng cấu; foo, caa => đẳng cấu) 
        public bool IsIsomorphic(string s, string t)
        {
            bool result = false;
            int s_pos = 0, t_pos = 0;

            if (s != "" && t != "")
            {
                for (int i = 0; i < s.Length; i++)
                {
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[i] == s[j]) s_pos+= i + j;//Plus position of i and j
                        if (t[i] == t[j]) t_pos+= i + j;//Plus Postion of i and j
                    }
                    if (s_pos == t_pos)//If sum of positions of two string s and t equals to each others => They have the right postion
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                    s_pos = 0;
                    t_pos = 0;
                }
            }
            else result = true;

            return result;
        }
    }
}
