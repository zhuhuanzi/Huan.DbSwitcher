using Huan.DbSwitcher.FreeSqlStore.Repositories;
using Huan.DbSwitcher.Store.Repositories;

namespace Huan.DbSwitcher.FreeSqlStore
{
    public static class FreeSqlDbRepositoryFactoryExtensions
    {

        /// <summary>
        /// 获取 freeSql 实体仓储,默认值 FreeSqlDbStoreConsts.DefaultFSqlRepositoryName
        /// </summary>
        /// <typeparam name="TEntity">实体</typeparam>
        /// <typeparam name="TPrimaryKey">实体主键</typeparam>
        /// <param name="dbRepositoryFactory">仓储工厂</param>
        /// <returns>返回仓储实例</returns>
        public static IFSqlRepository<TEntity, TPrimaryKey> GetDefaultIFreeRepository<TEntity, TPrimaryKey>(this IDbRepositoryFactory dbRepositoryFactory)
             where TEntity : class, IDbEntity<TPrimaryKey>
        {
            return (IFSqlRepository<TEntity, TPrimaryKey>)dbRepositoryFactory.GetDbRepository<TEntity, TPrimaryKey>(FreeSqlDbStoreConsts.DefaultFSqlRepositoryName);
        }

        /// <summary>
        /// 获取 freeSql 实体仓储
        /// </summary>
        /// <typeparam name="TEntity">实体</typeparam>
        /// <typeparam name="TPrimaryKey">实体主键</typeparam>
        /// <param name="dbRepositoryFactory">仓储工厂</param>
        /// <param name="mongoRepositoryName">仓储类型映射名称</param>
        /// <returns>返回仓储实例</returns>
        public static IFSqlRepository<TEntity, TPrimaryKey> GetIFreeRepository<TEntity, TPrimaryKey>(this IDbRepositoryFactory dbRepositoryFactory, string mongoRepositoryName)
            where TEntity : class, IDbEntity<TPrimaryKey>
        {
            return (IFSqlRepository<TEntity, TPrimaryKey>)dbRepositoryFactory.GetDbRepository<TEntity, TPrimaryKey>(mongoRepositoryName);
        }

    }
}
