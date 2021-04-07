using Huan.DbSwitcher.Store.Repositories;

namespace Huan.DbSwitcher.Repositories
{
    public interface IDynamicChangeRepository<TEntity, TPrimaryKey> : IDbRepository<TEntity, TPrimaryKey>
        where TEntity : class, IDbEntity<TPrimaryKey>
    {
        /// <summary>
        /// Id生成器
        /// </summary>
        IDbEntityIdGen EntityIdGen { get; }

        IDbRepository<TEntity, TPrimaryKey> DbRepository { get; }
    }
}