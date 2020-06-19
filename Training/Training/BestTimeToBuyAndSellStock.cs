using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)//Chọn mua ntn để có lời nhất: tham khảo đề bài trên trang LeetCode (Best Time to Buy and Sell Stock)
        {
            int sum = 0, max = 0, i = 0, j = 1;
            while(i < prices.Length - 1)
            {
                if(prices[j] > prices[i])
                {
                    sum = prices[j] - prices[i];
                    if(sum > max)
                    {
                        max = sum;
                    }
                }
                j++;
                if (j >= prices.Length)
                {
                    i++;
                    j = i +1;
                }
            }
            return max;
        }
    }
}
