using System;
using Huan.DbSwitcher.Store.Uow;
using MongoDB.Driver;

namespace Huan.DbSwitcher.MongoStore.Uow
{
    public class MongoDbUnitOfWork : IDbUnitOfWork
    {
        public Guid Id { get; private set; }

        public IClientSessionHandle Outer { get; private set; }

        public bool IsDispose { get; private set; }

        protected Action DisposeAction;

        public MongoDbUnitOfWork(IClientSessionHandle unitOfWork, Action disposeAction)
        {
            Outer = unitOfWork;
            DisposeAction = disposeAction;

            this.Id = Guid.NewGuid();
        }

        public void Commit()
        {
            this.Outer?.CommitTransaction();
        }


        public void Rollback()
        {
            this.Outer?.AbortTransaction();
        }

        public void Dispose()
        {
            if (!this.IsDispose)
            {
                this.IsDispose = true;
                this.Outer?.Dispose();
                this.Outer = null;
                this.DisposeAction?.Invoke();
            }
        }

    }
}
