using DTI.Core.Application.Ports.Out;
using DTI.Core.Application.UseCases.Core;
using DTI.Core.Domain.Interfaces.Entities;

namespace DTI.Core.Application.UseCases.DeleteEntity
{
    public abstract  class DeleteEntityCommandHandler<TEntity, TDeleteCommand> : CoreEntityCommandHandler<TEntity, TDeleteCommand>
        where TEntity : IEntity
        where TDeleteCommand : class, IEntityDTO
    {
        protected readonly IReaderRepository<TEntity> _readerRepository;
        protected DeleteEntityCommandHandler(IWriterRepository<TEntity> writerRepository) : base(writerRepository)
        {
            
        }

        public async Task Execute(TDeleteCommand command)
        {
            var entity = await _readerRepository.GetEntityByIdAsync(command.Id);
            entity.Inativate();
            await _writerRepository.UpdateAsync(entity);
        }
    }
}
