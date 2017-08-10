using System;

namespace SimpleFactroy
{
    public class BlackTea : IBeverageProvide
    {
        public void AddMaterial()
        {
            Console.WriteLine("加紅茶");
        }

        public void Brew()
        {
            Console.WriteLine("沖泡紅茶");
        }

        public void PouredCup()
        {
            Console.WriteLine("裝杯紅茶");
        }
    }
}
