namespace DesignPatterns.Messaging
{
    public class SimpleSender : ISender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending: {message}");
        }
    }
}
