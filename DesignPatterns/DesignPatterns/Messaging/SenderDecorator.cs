namespace DesignPatterns.Messaging
{
    public abstract class SenderDecorator : ISender
    {
        protected ISender _wrappedSender;

        protected SenderDecorator(ISender sender)
        {
            _wrappedSender = sender;
        }

        public virtual void Send(string message)
        {
            _wrappedSender.Send(message);
        }
    }
}
