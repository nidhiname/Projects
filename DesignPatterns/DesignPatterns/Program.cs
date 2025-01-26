// See https://aka.ms/new-console-template for more information
using DesignPatterns.EventSourcing.EventSourcing.Events;
using DesignPatterns.EventSourcing;
using DesignPatterns.FluentInterface.FluentInterface;
using DesignPatterns.Messaging;
using DesignPatterns.NullObject;
using DesignPatterns.SpecificationPattern;
using DesignPatterns.State;

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


//Fluent Interface Pattern
Person person = new PersonBuilder()
                        .SetFirstName("Shrinidhi")
                        .SetLastName("Acharya")
                        .SetAge(27) // I wish!
                        .Build();

// Output the result
Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age}");


//Null Object Pattern
IMessageSender sender;

bool isMessageSenderAvailable = false; 
sender = isMessageSenderAvailable ? new RealMessageSender() : new NullMessageSender(); 
sender.SendMessage("Hello from Null Object handler!");


//Specification Pattern
List<Customer> customers = new List<Customer>
        {
            new Customer("Alice", 30, "New York"),
            new Customer("Bob", 25, "California"),
            new Customer("Charlie", 35, "New York"),
            new Customer("David", 28, "California")
        };

// Create specifications
var ageSpecification = new CustomerAgeSpecification(30);
var locationSpecification = new CustomerLocationSpecification("New York");
var combinedSpecification = new AndSpecification<Customer>(ageSpecification, locationSpecification);

var filteredCustomers = customers.Where(c => combinedSpecification.IsSatisfiedBy(c)).ToList();

Console.WriteLine("Filtered Customers:");
foreach (var customer in filteredCustomers)
{
    Console.WriteLine($"{customer.Name}, {customer.Age}, {customer.Location}");
}

//State Pattern
TrafficLight trafficLight = new TrafficLight();

for (int i = 0; i < 6; i++)
{
    trafficLight.Change();
    System.Threading.Thread.Sleep(1000); // Simulate time delay between state changes
}

//EventSourcing Pattern
var eventStore = new EventStore();
var bankAccount = new BankAccount();

// Record some events
eventStore.SaveEvent(new DepositEvent(100));
eventStore.SaveEvent(new DepositEvent(50));
eventStore.SaveEvent(new WithdrawalEvent(30));

bankAccount.ReplayEvents(eventStore.GetAllEvents());

Console.WriteLine($"Current Balance: {bankAccount.Balance}");