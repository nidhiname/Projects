using System.Text;

namespace DesignPatterns.Messaging
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
