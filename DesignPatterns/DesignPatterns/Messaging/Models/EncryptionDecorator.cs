using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Messaging.Models
{
    public class EncryptionDecorator : SenderDecorator
    {
        public EncryptionDecorator(ISender sender) : base(sender) { }

        public override void Send(string message)
        {
            string encryptedMessage = Encrypt(message);
            base.Send(encryptedMessage);
        }

        private string Encrypt(string message)
        {
            // Simple encryption (Base64 encoding)
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            return Convert.ToBase64String(messageBytes);
        }
    }
}
