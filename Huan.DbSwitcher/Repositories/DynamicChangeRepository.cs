using System;
using Huan.DbSwitcher.FreeSqlStore;
using Huan.DbSwitcher.MongoStore;
using Huan.DbSwitcher.Store;
using Huan.DbSwitcher.Store.Repositories;

namespace Huan.DbSwitcher.Repositories
{
    public class DynamicChangeRepository<TEntity, TPrimaryKey> : BaseDbRepository<TEntity, TPrimaryKey>,
        IDynamicChangeRepository<TEntity, TPrimaryKey>
        where TEntity : class, IDbEntity<TPrimaryKey>
    {
        public IDbEntityIdGen EntityIdGen { get; }

        public IDbRepository<TEntity, TPrimaryKey> DbRepository => DbStorage;

        private readonly IDisposable _changeProvider;


        public DynamicChangeRepository(IDbRepositoryFactory storageFactory, IDbEntityIdGen dbEntityIdGen, IServiceProvider serviceProvider, IDisposable changeProvider)
            : base(storageFactory, serviceProvider)
        {
            this.EntityIdGen = dbEntityIdGen;
            _changeProvider = changeProvider;
        }

        protected override IDbRepository<TEntity, TPrimaryKey> CreateDbStorage(IDbRepositoryFactory storageFactory)
        {
            IDbRepository<TEntity, TPrimaryKey> repo;

            switch (DatabaseTypeChange)
            {
                // ReSharper disable once UnreachableSwitchCaseDueToIntegerAnalysis
                case DatabaseType.MongoDB:
                    repo = storageFactory.GetDefaultIMongoRepository<TEntity, TPrimaryKey>();
                    break;
                    
                default:
                    repo = storageFactory.GetDefaultIFreeRepository<TEntity, TPrimaryKey>();
                    break;
            }


            return repo;
        }


        public new void Dispose()
        {
            _changeProvider?.Dispose();

            DbStorage.Dispose();
        }

    }

}