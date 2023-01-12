using DTI.Core.Application.Ports.Out;
using DTI.Core.Domain.Interfaces.Entities;

namespace DTI.Core.Application.UseCases.Core
{
    public abstract  class CoreEntityCommandHandler<TEntity, TCommand>
        where TEntity : IEntity
        where TCommand : class
    {
        protected readonly IWriterRepository<TEntity> _writerRepository;
        protected CoreEntityCommandHandler(IWriterRepository<TEntity> writerRepository)
        {
            _writerRepository = writerRepository;
        }


    }
}
