using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IQueryRepository<TEntity, TKey, in TQuery> where TEntity : IKey<TKey>
    {
        Task<IEnumerable<TEntity>> Query(TQuery query);
    }
}