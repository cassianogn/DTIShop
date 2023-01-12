using DTI.Core.Domain.Interfaces.Entities;

namespace DTI.Core.Application.Ports.Out
{
    public interface IReaderRepository<TEntity> where TEntity : IEntity
    {
        Task<TEntity> GetEntityByIdAsync(Guid id);

    }
}
