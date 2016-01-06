using System;

namespace DP.Strategy
{
    class WedCalculator : IStrategy
    {
        public int Calculate(int listPrice)
        {
            double price = listPrice;

            if (price > 1000)
            {
                Random r = new Random();
                price = price * r.NextDouble();
            }

            return Convert.ToInt32(price);
        }
    }
}
