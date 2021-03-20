using System;

namespace Huan.DbSwitcher.Store.Partition
{
    public abstract class PartitionTableNameFactory : IPartitionTableNameFactory
    {
        public virtual string GetPartitionTableName(string basicTableName, object partitionId)
        {
            if (partitionId == null) return basicTableName;

            if (partitionId is DateTime dt) return $"{basicTableName}{dt:yyyyMM}"; //Month

            //if (partitionId is string s) 
            return $"{basicTableName}{partitionId}";
        }
    }
}