using System;
using Sample.Core.Common.Data.Interfaces;

namespace Sample.Core.Common.Data
{
    /// <summary>
    ///     Used for full audit such as (creation, modification and deletion) for an entity,
    /// </summary>
    public class FullAuditedEntity : AuditedEntity, IFullAudited
    {
        public virtual bool IsDeleted { get; set; }
        public virtual long? DeleterUserId { get; set; }
        public virtual DateTime? DeletionTime { get; set; }
    }
}