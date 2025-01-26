using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Messaging.Models
{
    public class SimpleSender : ISender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending: {message}");
        }
    }
}
