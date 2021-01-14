using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            int result = 0, cur = 0, index = 0;
            while(index < s.Length)
            {
                cur = Special(index, s, s[index]);
                if (cur == 0)
                {
                    result += Value(s[index]);
                }
                else
                {
                    result += cur;
                    index += 1;
                }
                index++;
            }
            return result;
        }

        public int Special(int i, string s, char t)
        {
            int val = 0;
            if(i + 1 <= s.Length - 1)
            {
                if (t == 'I' && s[i + 1] == 'V') return 4;
                if (t == 'I' && s[i + 1] == 'X') return 9;
                if (t == 'X' && s[i + 1] == 'L') return 40;
                if (t == 'X' && s[i + 1] == 'C') return 90;
                if (t == 'C' && s[i + 1] == 'D') return 400;
                if (t == 'C' && s[i + 1] == 'M') return 900;
            }
            return val;
        }

        public int Value(char i)
        {
            int val = 0;
            switch (i)
            {
                case 'I':
                    val =  1;
                    break;
                case 'V':
                    val = 5;
                    break;
                case 'X':
                    val = 10;
                    break;
                case 'L':
                    val = 50;
                    break;
                case 'C':
                    val = 100;
                    break;
                case 'D':
                    val = 500;
                    break;
                case 'M':
                    val = 1000;
                    break;
            }
            return val;
        }
    }
}
