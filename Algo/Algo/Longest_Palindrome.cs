using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class Longest_Palindrome
    {
        public int LongestPalindrome(string s)
        {
            Dictionary<char, int> pa_dict = new Dictionary<char, int>();
            int total = 0;
            int value = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (!pa_dict.ContainsKey(s[i]))
                {
                    pa_dict.Add(s[i], 1);
                }
                else
                {
                    value = pa_dict[s[i]];
                    value++;
                    pa_dict[s[i]] = value;
                }
            }

            foreach (var item in pa_dict)
            {
                if (item.Value % 2 == 0)
                {
                    total += item.Value;
                }
                else total += (item.Value - 1);
            }

            if ((total + 1) % 2 != 0 && total != s.Length)
            {
                total++;
            }

            return total;
        }
    }
}
