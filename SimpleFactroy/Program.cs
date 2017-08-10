using System;

namespace SimpleFactroy
{
    /// <summary>
    /// reference from http://www.dotblogs.com.tw/joysdw12/archive/2013/06/23/design-pattern-simple-factory-pattern.aspx
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            BeverageStores store = new BeverageStores(new SimpleBeverageFactory());

            Console.WriteLine("A 客人點了綠茶");
            store.BeverageOrders("GreenTea");

            Console.WriteLine("B 客人點了紅茶");
            store.BeverageOrders("BlackTea");

            Console.ReadLine();
        }
    }
}
