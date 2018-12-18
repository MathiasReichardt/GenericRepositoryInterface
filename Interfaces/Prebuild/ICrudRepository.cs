namespace Interfaces.Prebuild
{
    public interface ICrudRepository<TEntity, TKey, in TQuery>
        : IGetByKeyRepository<TEntity, TKey>,
            IAddRepository<TEntity, TKey>,
            IRemoveRepository<TEntity, TKey>,
            IQueryRepository<TEntity, TKey, TQuery> where TEntity : IKey<TKey>
    {
    }
}