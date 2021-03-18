namespace Huan.DbStorage
{
    /// <summary>
    /// 用于分区表的描述信息
    /// </summary>
    public interface IPartitionTable : IDbEntity<string>
    {
        /// <summary>
        /// 实际映射到的分区表名
        /// </summary>
        string TableName { get; set; }
    }
}