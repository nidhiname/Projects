namespace DesignPatterns.EventSourcing
{
    public class EventStore
    {
        private readonly List<IEvent> _events = new();

        public void SaveEvent(IEvent @event)
        {
            _events.Add(@event);
        }

        public IEnumerable<IEvent> GetAllEvents() => _events;
    }
}
