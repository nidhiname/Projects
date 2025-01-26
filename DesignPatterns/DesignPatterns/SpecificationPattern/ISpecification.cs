namespace DesignPatterns.SpecificationPattern
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T entity);
    }
}
