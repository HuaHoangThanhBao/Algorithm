using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            string a = String.Concat(s.OrderBy(c => c));
            string b = String.Concat(t.OrderBy(c => c));

            return a == b;
        }
    }
}
