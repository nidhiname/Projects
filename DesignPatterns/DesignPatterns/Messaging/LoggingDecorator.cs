namespace DesignPatterns.Messaging
{
    public class LoggingDecorator : SenderDecorator
    {
        public LoggingDecorator(ISender sender) : base(sender) { }

        public override void Send(string message)
        {
            Console.WriteLine($"[Log] Sending message: {message}");
            base.Send(message);
        }
    }
}
