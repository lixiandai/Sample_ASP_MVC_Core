using System;

namespace Sample.Core.Common.Data.Interfaces
{
    public interface ICreationAudited
    {
        /// <summary>
        ///     Gets or sets the creation time.
        /// </summary>
        /// <value>
        ///     The creation time.
        /// </value>
        DateTime CreationTime { get; set; }

        /// <summary>
        ///     Gets or sets the creator user identifier.
        /// </summary>
        /// <value>
        ///     The creator user identifier.
        /// </value>
        long? CreatorUserId { get; set; }
    }
}