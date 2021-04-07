namespace Huan.DbSwitcher.Store.Repositories
{

    public interface IDbEntity<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }
}
