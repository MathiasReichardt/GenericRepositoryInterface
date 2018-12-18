using System.Threading.Tasks;

namespace Interfaces
{
    public interface IGetByKeyRepository<TEntity, in TKey>
    {
        Task<TEntity> GetByKey(TKey key);
    }
}