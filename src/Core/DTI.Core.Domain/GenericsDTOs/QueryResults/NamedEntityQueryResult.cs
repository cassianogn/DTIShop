using DTI.Core.Domain.Interfaces.QueryResults;

namespace DTI.Core.Domain.GenericsDTOs.QueryResults
{
    public class NamedEntityQueryResult : INamedEntityQueryResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
