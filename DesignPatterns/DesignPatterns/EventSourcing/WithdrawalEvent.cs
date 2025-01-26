using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EventSourcing
{
    public class WithdrawalEvent : BaseEvent
    {
        public decimal Amount { get; }

        public WithdrawalEvent(decimal amount)
        {
            Amount = amount;
        }
    }
}
