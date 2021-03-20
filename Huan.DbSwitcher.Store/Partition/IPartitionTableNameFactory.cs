namespace Huan.DbSwitcher.Store.Partition
{
    public interface IPartitionTableNameFactory
    {
        /// <summary>
        /// The get partition table name
        /// </summary>
        /// <param name="basicTableName"></param>
        /// <param name="partitionId"></param>
        /// <returns></returns>
        string GetPartitionTableName(string basicTableName, object partitionId);
    }
}