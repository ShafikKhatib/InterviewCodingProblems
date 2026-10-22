using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodingProblems
{
    internal class Buy___Sell_Stock
    {
        int MaxProfit(int[] prices)
        {
            int min = int.MaxValue, profit = 0;

            foreach (int p in prices)
            {
                min = Math.Min(min, p);
                profit = Math.Max(profit, p - min);
            }
            return profit;
        }
    }

    //Best time to sell and buy stock

}
