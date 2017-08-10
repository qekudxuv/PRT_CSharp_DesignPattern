using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IService svc = new ServiceProxy();
            svc.Execute();

            Console.ReadLine();
        }
    }
}
