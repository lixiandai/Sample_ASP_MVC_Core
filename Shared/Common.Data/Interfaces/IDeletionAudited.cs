using System;

namespace Sample.Core.Common.Data.Interfaces
{
    /// <summary>
    ///     Store information when an entity is deleted and who deleted it
    /// </summary>
    public interface IDeletionAudited
    {
        /// <summary>
        ///     Gets or sets a value indicating whether this instance is deleted.
        ///     Soft delete is pattern to mark an Entity as deleted instead of actually deleting it from database.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is deleted; otherwise, <c>false</c>.
        /// </value>
        bool IsDeleted { get; set; }

        /// <summary>
        ///     Gets or sets the deleter user identifier.
        /// </summary>
        /// <value>
        ///     The deleter user identifier.
        /// </value>
        long? DeleterUserId { get; set; }

        /// <summary>
        ///     Gets or sets the deletion time.
        /// </summary>
        /// <value>
        ///     The deletion time.
        /// </value>
        DateTime? DeletionTime { get; set; }
    }
}