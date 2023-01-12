using DTI.Core.Application.Ports.Out;
using DTI.Core.Application.UseCases.Core;
using DTI.Core.Domain.Interfaces.Entities;

namespace DTI.Core.Application.UseCases.AddEntity
{
    public abstract class AddEntityCommandHandler<TEntity, TAddCommand> : CoreEntityCommandHandler<TEntity, TAddCommand>
        where TEntity: IEntity 
        where TAddCommand : class
    {
        protected AddEntityCommandHandler(IWriterRepository<TEntity> writerRepository) : base(writerRepository)
        {
        }

        public virtual async Task<Guid> Execute(TAddCommand command)
        {
            var entity = MapCommandToEntity(command);
            await _writerRepository.AddAsync(entity);
            return entity.Id;
        }
        public abstract TEntity MapCommandToEntity(TAddCommand command);

    }
}
