using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.SimpleFactroy
{
    public class BeverageStores
    {
        private SimpleBeverageFactory _factory;

        public BeverageStores(SimpleBeverageFactory pFactory)
        {
            _factory = pFactory;
        }

        public IBeverageProvide BeverageOrders(string pBeverageType)
        {
            IBeverageProvide beverage;
            beverage = _factory.CreateBeverage(pBeverageType);

            beverage.AddMaterial(); // 加料
            beverage.Brew(); // 沖泡
            beverage.PouredCup(); // 裝杯

            return beverage;
        }
    }
}
