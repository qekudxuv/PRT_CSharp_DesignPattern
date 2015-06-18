using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.SimpleFactroy
{
    public class SimpleBeverageFactory
    {
        public IBeverageProvide CreateBeverage(string pBeverageType)
        {
            IBeverageProvide beverage;
            if (pBeverageType == "GreenTea")
                return beverage = new GreenTea();
            if (pBeverageType == "BlackTea")
                return beverage = new BlackTea();
            else
                return null;
        }
    }
}
