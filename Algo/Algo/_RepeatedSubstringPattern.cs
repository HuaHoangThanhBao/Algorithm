using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class _RepeatedSubstringPattern
    {
        /*Approach 2
        Assume the repeated substring is T, then the string s would be TT.
        s+s would be TTTT.
        After removing the first and last character, s+s would be QTTQ, which contains TT.
        */
        public bool RepeatedSubstringPattern(string s)
        {
            return (s + s).Substring(1, 2 * s.Length - 2).Contains(s);
        }
    }
}
