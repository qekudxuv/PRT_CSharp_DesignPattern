namespace Strategy
{
	public class StoreContext
	{
		//促銷模式計算器
		private IStrategy _calculator = null;

		public StoreContext(IStrategy calculator)
		{
			this._calculator = calculator;
		}

		public int GetTotal(int listPrice)
		{
			return _calculator.Calculate(listPrice);
		}
	}
}
