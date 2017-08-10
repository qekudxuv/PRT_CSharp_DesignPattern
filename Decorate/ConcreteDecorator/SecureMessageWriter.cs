using System;

namespace Decorate
{
    class SecureMessageWriter : IMessageWriter
    {
        private string message;

        //被裝飾者
        private IMessageWriter messageWriter;

        public SecureMessageWriter(IMessageWriter msgWriter)
        {
            this.messageWriter = msgWriter;
        }

        public string Message
        {
            set { message = value; }
        }

        public void WriteMessage(string filePath)
        {
            if (this.ValidateUser())
            {
                Console.WriteLine("Message驗證已通過");
                //添加新的行為
                //正如你所見,在調用被裝飾者的標準方法前我們添加了驗證行為
                messageWriter.Message = this.message;
                messageWriter.WriteMessage(filePath);
            }
            else
            {
                Console.WriteLine("Message驗證未通過");
            }
        }
        private bool ValidateUser()
        {
            //驗證使用者代碼
            return true;
        }
    }
}
