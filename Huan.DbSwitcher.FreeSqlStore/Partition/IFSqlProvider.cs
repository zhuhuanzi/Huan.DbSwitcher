using System;

namespace Huan.DbSwitcher.FreeSqlStore.Partition
{
    public interface IFSqlProvider : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        string ProviderName { get; }

        /// <summary>
        /// FreeSql实例
        /// </summary>
        IFreeSql FSql { get; }
    }
}
