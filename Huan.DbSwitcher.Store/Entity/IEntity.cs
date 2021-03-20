namespace Huan.DbSwitcher.Store.Entity
{
    public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }
}
