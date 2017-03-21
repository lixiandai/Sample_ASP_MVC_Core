using Sample.Core.Common.Data.Interfaces;

namespace Sample.Core.Common.Data
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
    }
}