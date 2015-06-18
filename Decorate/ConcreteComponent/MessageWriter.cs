using DP.Decorate.Component;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Decorate.ConcreteComponent
{
    class MessageWriter : IMessageWriter
    {
        private string message;
        public string Message { set { message = value; } }

        public virtual void WriteMessage(string filePath)
        {
            Console.WriteLine("Message已寫入檔案");
            File.WriteAllText(filePath, message);
        }
    }
}
