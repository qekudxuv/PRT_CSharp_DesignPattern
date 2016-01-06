using DP.Adapter.Interface;

namespace DP.Adapter
{
    //https://www.dotblogs.com.tw/pin0513/2010/05/30/15497
    //需要一隻 duck 去假裝 penguin
    public class DuckAdapter : IPenguin
    {
        private IDuck _duck;

        public DuckAdapter(IDuck duck)
        {
            _duck = duck;
        }

        public void Penguin_Walk()
        {
            _duck.Duck_Walk();
        }

        public void Penguin_gobble()
        {
            _duck.Duck_quack();
        }
    }
}
