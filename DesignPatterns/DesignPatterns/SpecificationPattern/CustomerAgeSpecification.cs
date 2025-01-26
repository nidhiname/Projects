namespace DesignPatterns.SpecificationPattern
{
    public class CustomerAgeSpecification : ISpecification<Customer>
    {
        private readonly int _minAge;

        public CustomerAgeSpecification(int minAge)
        {
            _minAge = minAge;
        }

        public bool IsSatisfiedBy(Customer customer)
        {
            return customer.Age >= _minAge;
        }
    }
}
