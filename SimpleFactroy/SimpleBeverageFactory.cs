namespace SimpleFactroy
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
