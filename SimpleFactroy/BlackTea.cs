using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.SimpleFactroy
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
