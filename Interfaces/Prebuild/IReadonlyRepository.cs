namespace Interfaces.Prebuild
{
    public interface IReadonlyRepository<TEntity, TKey, in TQuery>
        : IGetByKeyRepository<TEntity, TKey>,
            IQueryRepository<TEntity, TKey, TQuery> where TEntity : IKey<TKey>
    {
    }
}