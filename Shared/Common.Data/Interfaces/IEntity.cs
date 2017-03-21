namespace Sample.Core.Common.Data.Interfaces
{
    public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }


    public interface IEntity : IEntity<int>
    {
    }
}