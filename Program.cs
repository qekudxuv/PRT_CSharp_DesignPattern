using DP.Decorate.Component;
using DP.Decorate.ConcreteComponent;
using DP.Decorate.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Decorate
            //IMessageWriter msgWriter = new EncryptedMessageWriter(new MessageWriter());
            //IMessageWriter msgWriter = new SecureMessageWriter(new MessageWriter());
            //IMessageWriter msgWriter = new EncryptedMessageWriter(new SecureMessageWriter(new MessageWriter()));
            IMessageWriter msgWriter = new SecureMessageWriter(new EncryptedMessageWriter(new MessageWriter()));
            msgWriter.Message = "test";
            msgWriter.WriteMessage("D:\\test.txt");

            //SimpleFactroy
            //http://www.dotblogs.com.tw/joysdw12/archive/2013/06/23/design-pattern-simple-factory-pattern.aspx
            DP.SimpleFactroy.BeverageStores store = new DP.SimpleFactroy.BeverageStores(new DP.SimpleFactroy.SimpleBeverageFactory());
            Console.WriteLine("A 客人點了綠茶");
            store.BeverageOrders("GreenTea");
            Console.WriteLine("B 客人點了紅茶");
            store.BeverageOrders("BlackTea");

            Console.ReadLine();
        }
    }
}
