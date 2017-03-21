namespace Sample.Core.Common.Data.Interfaces
{
    /// <summary>
    ///     Used for full Audit such as (creation, modification and deletion) for an entity,
    /// </summary>
    /// <seealso cref="IAudited" />
    /// <seealso cref="Sample.Core.Common.Data.Interfaces.IDeletionAudited" />
    public interface IFullAudited : IAudited, IDeletionAudited
    {
    }
}