using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Messaging.Models
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
