namespace DTI.Core.Domain.Interfaces.Entities
{
    public interface IEntity
    {
        Guid Id { get; }

        void Inativate();
    }
}
