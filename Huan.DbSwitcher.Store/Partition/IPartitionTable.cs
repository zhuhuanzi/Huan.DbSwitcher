using Huan.DbSwitcher.Store.Entity;

namespace Huan.DbSwitcher.Store.Partition
{
    public interface IPartitionTable : IEntity<string>
    {
        /// <summary>
        /// The partition table name
        /// </summary>
        string TableName { get; set; }
    }
}