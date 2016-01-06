using System;

namespace DP.Strategy
{
    class MonCalculator : IStrategy
    {
        public int Calculate(int listPrice)
        {
            double price = listPrice;

            if (listPrice > 1000)
            {
                price -= 50;                    
            }

            return Convert.ToInt32(price);
        }
    }
}
