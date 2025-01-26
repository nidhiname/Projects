// See https://aka.ms/new-console-template for more information
using DesignPatterns.Messaging.Models;

Console.WriteLine("Hello, World!");
ISender simpleSender = new SimpleSender();

// Add logging functionality
ISender loggedSender = new LoggingDecorator(simpleSender);

// Add encryption functionality on top of logging
ISender encryptedLoggedSender = new EncryptionDecorator(loggedSender);

Console.WriteLine("Sending with Logging and Encryption:");
simpleSender.Send("Hello Reader!");
loggedSender.Send("Hello MEDIUM Reader!");
encryptedLoggedSender.Send("Hello, Decrypted to Read this!");