using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class ReverseStrings
    {
        public void ReverseString(char[] s)
        {
            int cur = 0;
            char temp = ' ';
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (i < s.Length / 2)
                {
                    temp = s[cur];
                    s[cur] = s[i];
                    s[i] = temp;
                }
                cur++;
            }
        }
    }
}
