using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet
{
    internal class Stocks
    {
        public int MaxProfit(int[] prices)
        {
            int Max = prices[0];
            int Min = prices[0];
            int diff = 0;
            int curr_diff = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] > Max)
                {
                    Max = prices[i];
                }

                if (prices[i] < Min)
                {
                    Min = prices[i];
                    Max = 0;
                }

                curr_diff = Max - Min;
                if (diff < curr_diff)
                {
                    diff = curr_diff;
                }

            }

            return diff;
        }
    }
}
