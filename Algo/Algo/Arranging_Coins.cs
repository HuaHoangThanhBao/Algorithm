using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class Arranging_Coins
    {
        public int ArrangeCoins(int n)
        {
            int coin = 0;
            int count = 1;
            while(n > 0)
            {
                coin++;
                count += 1;
                n -= count;
            }
            return coin;
        }
    }
}
