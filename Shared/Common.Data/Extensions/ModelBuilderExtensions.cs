using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Sample.Core.Common.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        /// <summary>
        ///     Removes the pluralizing table name convention.
        /// </summary>
        /// <param name="modelBuilder">The model builder.</param>
        public static void RemovePluralizingTableNameConvention(this ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
                entity.Relational().TableName = entity.DisplayName();
        }
    }
}