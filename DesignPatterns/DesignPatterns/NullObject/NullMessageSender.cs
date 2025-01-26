namespace DesignPatterns.NullObject
{
    public class NullMessageSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            // Does nothing, no-op behavior.
            Console.WriteLine($"NULL OBJECT to send message");
        }
    }
}
