using System;

namespace SimpleFactroy
{
    public class GreenTea : IBeverageProvide
    {
        public void AddMaterial()
        {
            Console.WriteLine("加綠茶");
        }

        public void Brew()
        {
            Console.WriteLine("沖泡綠茶");
        }

        public void PouredCup()
        {
            Console.WriteLine("裝杯綠茶");
        }
    }
}
