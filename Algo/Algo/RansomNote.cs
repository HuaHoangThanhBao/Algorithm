using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> ma_dict = new Dictionary<char, int>();
            Dictionary<char, int> ran_dict = new Dictionary<char, int>();
            int count = 0;

            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (ran_dict.ContainsKey(ransomNote[i]))
                {
                    ran_dict[ransomNote[i]]++;
                }
                else ran_dict.Add(ransomNote[i], 1);
            }

            for (int i = 0; i < magazine.Length; i++)
            {
                if (ma_dict.ContainsKey(magazine[i]))
                {
                    ma_dict[magazine[i]]++;
                }
                else ma_dict.Add(magazine[i], 1);
            }

            foreach(var item in ma_dict)
            {
                if (ran_dict.ContainsKey(item.Key))
                {
                    if (item.Value >= ran_dict[item.Key])
                        count++;
                }
            }

            if (count == ran_dict.Count) return true;
            else return false;
        }
    }
}
