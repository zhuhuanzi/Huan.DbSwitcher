using System;

namespace Huan.DbSwitcher.Store.Repositories
{
    public class GuidDbEntityIdGen : IDbEntityIdGen
    {
        public string Next
        {
            get => Guid.NewGuid().ToString().Replace("-", string.Empty);
        }
    }
}
