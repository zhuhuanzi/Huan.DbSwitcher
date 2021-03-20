namespace Huan.DbSwitcher.Store.Entity
{
    public interface IEntityIdGen
    {
        string NextId { get; }
    }
}