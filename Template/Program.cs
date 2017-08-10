using System;

namespace Template
{
    /// <summary>
    /// Template pattern
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IMail mail = new FooMail();
            mail.SendMail();

            Console.ReadLine();
        }
    }
}
