using System;

namespace Singleton
{
    public class Singleton
    {
        //volatile關鍵字，這個關鍵字確保，當uniqueInstance變數被實體化的時候，多個執行緒處理uniqueInstance的作法是正確的。
        private volatile static Singleton _uniqueInstance;

        private static Object _lock = new Object();

        // Private constructor prevents instantiation from other classes
        private Singleton() { }

        public static Singleton GetInstance()
        {
            //雙重上鎖技巧.(Double-Checked Locking)
            if (_uniqueInstance == null)
            {
                lock (_lock)
                {
                    if (_uniqueInstance == null)
                    {
                        _uniqueInstance = new Singleton();
                    }
                }
            }
            return _uniqueInstance;
        }

        public void Execute()
        {
            Console.WriteLine("only one instance in the process");
        }
    }
}
