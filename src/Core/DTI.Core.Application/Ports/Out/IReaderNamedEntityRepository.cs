using DTI.Core.Domain.Interfaces.Entities;
using DTI.Core.Domain.Interfaces.QueryResults;

namespace DTI.Core.Application.Ports.Out
{
    public interface IReaderNamedEntityRepository<TNamedEntity> : IReaderRepository<TNamedEntity> where TNamedEntity : INamedEntity
    {
        Task<IReadOnlyCollection<INamedEntityQueryResult>> SearchEntityByName(string name = "");
    }
}
