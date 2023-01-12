namespace DTI.Core.Domain.Interfaces.Entities
{
    public interface INamedEntity : IEntity
    {
        string Name { get; }
    }
}
