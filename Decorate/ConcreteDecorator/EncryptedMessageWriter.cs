using DP.Decorate.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Decorate.ConcreteDecorator
{
    class EncryptedMessageWriter : IMessageWriter
    {
        private string message;

        //被裝飾者
        private IMessageWriter messageWriter;

        public EncryptedMessageWriter(IMessageWriter msgWriter) 
        {
            this.messageWriter = msgWriter;
        }

        public string Message 
        {
            set { message = value; }
        }

        public void WriteMessage(string filePath) 
        {
            Console.WriteLine("Message已加密");
            messageWriter.Message = this.EncryptMessage(message);//加密資訊
            //被裝飾得行為
            messageWriter.WriteMessage(filePath);
        }

        private string EncryptMessage(string message) 
        {
            return "(encrytedMsgInBase64)" + message;
        }
    }
}
