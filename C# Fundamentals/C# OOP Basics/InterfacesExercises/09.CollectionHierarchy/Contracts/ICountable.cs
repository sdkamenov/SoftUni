namespace _09.CollectionHierarchy.Contracts
{
    public interface ICountable : IRemovable
    {
        int NumberOfElements { get; }
    }
}
