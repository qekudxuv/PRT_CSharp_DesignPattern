using System;

namespace Proxy
{
    public class Service : IService
    {
        public void Execute()
        {
            Console.WriteLine("do real staff");
        }
    }
}
