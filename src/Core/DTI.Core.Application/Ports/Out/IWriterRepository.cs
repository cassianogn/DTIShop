using DTI.Core.Domain.Interfaces.Entities;

namespace DTI.Core.Application.Ports.Out
{
    public interface IWriterRepository<in TEntity> where TEntity : IEntity
    {
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
    }
}
