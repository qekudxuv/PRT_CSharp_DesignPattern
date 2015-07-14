namespace DP.Singleton
{
    //參考 http://www.dotblogs.com.tw/pin0513/archive/2010/03/08/13931.aspx
    public class Singleton
    {
        //volatile關鍵字，這個關鍵字確保，當uniqueInstance變數被實體化的時候，多個執行緒處理uniqueInstance的作法是正確的。
        private volatile static Singleton _uniqueInstance;

        // Private constructor prevents instantiation from other classes
        private Singleton() { }

        public static Singleton getInstance()
        {
            //雙重上鎖技巧.(Double-Checked Locking)
            if (_uniqueInstance == null)
            {
                lock (Singleton._uniqueInstance)
                {
                    if (_uniqueInstance == null)
                    {
                        _uniqueInstance = new Singleton();
                    }
                }
            }
            return _uniqueInstance;
        }
    }
}
