namespace Decorate
{
    interface IMessageWriter
    {
        string Message { set; }
        void WriteMessage(string filePath);
    }
}
