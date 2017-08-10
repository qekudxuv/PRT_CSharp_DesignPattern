using System;

namespace Strategy
{
    /// <summary>
    /// Strategy pattern
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int listPrice = 1000;

            StoreContext store1 = new StoreContext(new MonCalculator());
            int t1 = store1.GetTotal(listPrice);
            Console.WriteLine("total of Monday will be : " + t1);

            StoreContext store2 = new StoreContext(new TueCalculator());
            int t2 = store2.GetTotal(listPrice);
            Console.WriteLine("total of Tuesday will be : " + t2);

            StoreContext store3 = new StoreContext(new WedCalculator());
            int t3 = store3.GetTotal(listPrice);
            Console.WriteLine("total of Wednesday will be : " + t3);

            StoreContext store4 = new StoreContext(new NormalCalculator());
            int t4 = store4.GetTotal(listPrice);
            Console.WriteLine("total of normal day will be : " + t4);

            Console.ReadLine();
        }
    }
}
