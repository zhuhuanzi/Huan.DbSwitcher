namespace Huan.DbSwitcher.Store.Partition
{
    public interface IPartitionEntity
    {
        /// <summary>
        /// split table key
        /// </summary>
        object PartitionId { get; set; }
    }
}