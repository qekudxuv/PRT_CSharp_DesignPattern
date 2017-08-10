namespace Strategy
{
	class NormalCalculator : IStrategy
	{
		public int Calculate(int listPrice)
		{
			return listPrice;
		}
	}
}
