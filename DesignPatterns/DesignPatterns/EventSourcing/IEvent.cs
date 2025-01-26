namespace DesignPatterns.EventSourcing
{
    public interface IEvent
    {
        DateTime OccurredOn { get; }
    }
}
