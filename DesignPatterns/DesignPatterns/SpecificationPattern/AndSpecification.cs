namespace DesignPatterns.SpecificationPattern
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _first;
        private readonly ISpecification<T> _second;

        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            _first = first;
            _second = second;
        }

        public bool IsSatisfiedBy(T entity)
        {
            return _first.IsSatisfiedBy(entity) && _second.IsSatisfiedBy(entity);

        }
    }
}
