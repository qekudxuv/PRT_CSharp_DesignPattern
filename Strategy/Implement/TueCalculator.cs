using System;

namespace Strategy
{
    class TueCalculator : IStrategy
    {
        public int Calculate(int listPrice)
        {
            double price = listPrice;

            if (listPrice >= 1000)
            {
                price *= 0.9;
            }

            return Convert.ToInt32(price);
        }
    }
}
