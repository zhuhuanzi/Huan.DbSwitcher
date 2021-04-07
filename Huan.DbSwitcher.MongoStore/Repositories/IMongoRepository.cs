using Huan.DbSwitcher.MongoStore.Uow;
using Huan.DbSwitcher.Store.Repositories;
using Huan.DbSwitcher.Store.Uow;
using MongoDB.Driver;

namespace Huan.DbSwitcher.MongoStore.Repositories
{
    /// <summary>
    /// MongoDb 仓储类
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TPrimaryKey"></typeparam>
    public interface IMongoRepository<TEntity, TPrimaryKey> : IDbRepository<TEntity, TPrimaryKey>
         where TEntity : class, IDbEntity<TPrimaryKey>
    {
        /// <summary>
        /// 获取数据库
        /// </summary>
        /// <returns></returns>
        IMongoDatabase GetDatabase();

        /// <summary>
        /// 获取表
        /// </summary>
        /// <param name="partitionId">分表id</param>
        /// <returns></returns>
        IMongoCollection<TEntity> GetTable(object partitionId = null);

        /// <summary>
        /// 启动工作单元
        /// </summary>
        /// <returns></returns>
        IDbUnitOfWork BeginUnitOfWork(MongoUnitOfWorkOptions unitOfWorkOptions);
    }
}
