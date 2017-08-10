using System;

namespace Singleton
{
    /// <summary>
    /// reference from http://www.dotblogs.com.tw/pin0513/archive/2010/03/08/13931.aspx
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.GetInstance().Execute();

            Console.ReadLine();
        }
    }
}
