using DTI.Core.Application.Ports.Out;
using DTI.Core.Application.UseCases.Core;
using DTI.Core.Domain.Interfaces.Entities;

namespace DTI.Core.Application.UseCases.UpdateEntity
{
    public abstract class UpdateEntityCommandHandler<TEntity, TUpdateCommand> : CoreEntityCommandHandler<TEntity, TUpdateCommand>
        where TEntity : IEntity
        where TUpdateCommand : class, IEntityDTO
    {
        protected readonly IReaderRepository<TEntity> _readerRepository;
        protected UpdateEntityCommandHandler(IWriterRepository<TEntity> writerRepository, IReaderRepository<TEntity> readerRepository) : base(writerRepository)
        {
            _readerRepository = readerRepository;
        }

        public async Task Execute(TUpdateCommand command)
        {
            var entity = await _readerRepository.GetEntityByIdAsync(command.Id);
            
            entity = UpdateEntity(entity, command);
            
            await _writerRepository.UpdateAsync(entity);

        }

        protected abstract TEntity UpdateEntity(TEntity entity, TUpdateCommand command);
    }
}
