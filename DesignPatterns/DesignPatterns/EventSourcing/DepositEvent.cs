namespace DesignPatterns.EventSourcing
{
    namespace EventSourcing.Events
    {
        public class DepositEvent : BaseEvent
        {
            public decimal Amount { get; }

            public DepositEvent(decimal amount)
            {
                Amount = amount;
            }
        }
    }
}
