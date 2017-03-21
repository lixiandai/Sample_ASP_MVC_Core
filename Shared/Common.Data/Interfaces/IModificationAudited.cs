using System;

namespace Sample.Core.Common.Data.Interfaces
{
    public interface IModificationAudited
    {
        /// <summary>
        ///     Gets or sets the last modification time.
        /// </summary>
        /// <value>
        ///     The last modification time.
        /// </value>
        DateTime? LastModificationTime { get; set; }

        /// <summary>
        ///     Gets or sets the last modifier user identifier.
        /// </summary>
        /// <value>
        ///     The last modifier user identifier.
        /// </value>
        long? LastModifierUserId { get; set; }
    }
}