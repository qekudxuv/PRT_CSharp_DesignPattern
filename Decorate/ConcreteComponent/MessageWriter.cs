using System;
using System.IO;

namespace Decorate
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
