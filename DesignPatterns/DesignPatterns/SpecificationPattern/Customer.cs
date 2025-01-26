namespace DesignPatterns.SpecificationPattern
{
    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }

        public Customer(string name, int age, string location)
        {
            Name = name;
            Age = age;
            Location = location;
        }
    }
}
