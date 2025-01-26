namespace DesignPatterns.NullObject
{
    public class RealMessageSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending message: {message}");
        }
    }
}
 