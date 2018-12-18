using System.Threading.Tasks;

namespace Interfaces
{
    public interface IAddRepository<in TEntity, TKey> where TEntity : IKey<TKey>
    {
        Task Add(TEntity entity);
    }
}