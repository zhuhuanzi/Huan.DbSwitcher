using Huan.DbSwitcher.Store.Repositories;
using MongoDB.Bson;

namespace Huan.DbSwitcher.MongoStore.Repositories
{
    public class MongoDbEntityIdGen : IDbEntityIdGen
    {
        public string Next => ObjectId.GenerateNewId().ToString();

    }
}
