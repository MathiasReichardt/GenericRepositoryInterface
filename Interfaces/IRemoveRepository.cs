using System.Threading.Tasks;

namespace Interfaces
{
    public interface IRemoveRepository<in TEntity, TKey> where TEntity : IKey<TKey>
    {
        Task Remove(TEntity entity);
    }
}