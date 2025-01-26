namespace DesignPatterns.SpecificationPattern
{
    public class CustomerLocationSpecification : ISpecification<Customer>
    {
        private readonly string _location;

        public CustomerLocationSpecification(string location)
        {
            _location = location;
        }

        public bool IsSatisfiedBy(Customer customer)
        {
            return customer.Location == _location;
        }
    }
}
