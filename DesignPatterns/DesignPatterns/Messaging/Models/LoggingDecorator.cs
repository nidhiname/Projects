using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Messaging.Models
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
