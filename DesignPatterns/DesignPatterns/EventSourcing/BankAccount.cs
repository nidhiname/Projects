using DesignPatterns.EventSourcing.EventSourcing.Events;

namespace DesignPatterns.EventSourcing
{
    public class BankAccount
    {
        public decimal Balance { get; private set; }

        public void ApplyEvent(IEvent @event)
        {
            switch (@event)
            {
                case DepositEvent depositEvent:
                    Balance += depositEvent.Amount;
                    break;
                case WithdrawalEvent withdrawalEvent:
                    Balance -= withdrawalEvent.Amount;
                    break;
            }
        }

        public void ReplayEvents(IEnumerable<IEvent> events)
        {
            foreach (var @event in events)
            {
                ApplyEvent(@event);
            }
        }
    }
}
