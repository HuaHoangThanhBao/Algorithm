using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Subsequence
    {
        public bool IsSubsequence(string s, string t)
        {
            //s = "abc"
            //t = "ahbgdc";
            List<char> storage = new List<char>();
            bool isSub = true;
            for (int i = 0; i < t.Length; i++)
            {
                if (s.Contains(t[i])) storage.Add(t[i]);
            }

            //Console.WriteLine(storage.Count);

            if (storage.Count >= s.Length)
            {
                for (int i = 0; i < storage.Count; i++)
                {
                    if(i < s.IndexOf(storage[i]))
                    {
                        isSub = false;
                        break;
                    }    
                }
            }
            else isSub = false;

            return isSub;

            //Console.WriteLine(count_t);
        }
    }
}
