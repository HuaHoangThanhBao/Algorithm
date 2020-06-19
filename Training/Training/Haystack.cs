using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Haystack
    {
        public int StrStr(string haystack, string needle)//Return the index of the first occurrence of needle in haystack
        {
            int index = 0;
            if (needle.Length != 0)
            {
                if (!haystack.Contains(needle[0]))
                {
                    index = -1;
                }
                else
                {
                    for (int i = 0; i < haystack.Length; i++)
                    {
                        if (haystack[i].ToString() == needle[0].ToString())
                        {
                            index = i;
                            break;
                        }
                    }
                }
            }
            else
            {
                index = 0;
            }
            return index;
        }
    }
}
