using Huan.DbSwitcher.Store.Repositories;

namespace Huan.DbSwitcher.Store.Partition
{

    /// <summary>
    /// 用于分区表的描述信息
    /// </summary>
    public interface IPartitionTableInfo : IDbEntity<string>
    {
        /// <summary>
        /// 实际映射到的分区表名
        /// </summary>
        string TableName { get; set; }
    }
}
