using System;
using Sample.Core.Common.Data.Interfaces;

namespace Sample.Core.Common.Data
{
    /// <summary>
    ///     Used for full Audit such as (creation, modification) for an entity,
    /// </summary>
    /// <seealso cref="Sample.Core.Common.Data.Entity" />
    /// <seealso cref="Sample.Core.Common.Data.Interfaces.IAudited" />
    public abstract class AuditedEntity : Entity, IAudited
    {
        protected AuditedEntity()
        {
            CreationTime = DateTime.UtcNow;
        }

        public virtual DateTime CreationTime { get; set; }
        public virtual long? CreatorUserId { get; set; }
        public virtual DateTime? LastModificationTime { get; set; }
        public virtual long? LastModifierUserId { get; set; }
    }
}