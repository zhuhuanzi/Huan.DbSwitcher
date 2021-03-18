namespace Huan.DbStorage
{
    public interface IDbEntity<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }
}