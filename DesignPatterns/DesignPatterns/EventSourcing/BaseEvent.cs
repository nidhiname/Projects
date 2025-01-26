namespace DesignPatterns.EventSourcing
{
    public abstract class BaseEvent : IEvent
    {
        public DateTime OccurredOn { get; } = DateTime.UtcNow;
    }
}
