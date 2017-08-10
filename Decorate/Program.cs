namespace Decorate
{
    /// <summary>
    /// Decorate pattern
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //IMessageWriter msgWriter = new EncryptedMessageWriter(new MessageWriter());
            //IMessageWriter msgWriter = new SecureMessageWriter(new MessageWriter());
            //IMessageWriter msgWriter = new EncryptedMessageWriter(new SecureMessageWriter(new MessageWriter()));
            IMessageWriter msgWriter = new SecureMessageWriter(new EncryptedMessageWriter(new MessageWriter()));
            msgWriter.Message = "test";
            msgWriter.WriteMessage("D:\\test.txt");
        }
    }
}
