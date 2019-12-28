using AuditingDatabase;
using Microsoft.EntityFrameworkCore;

namespace Auditing
{
    internal static class DbContextMaps
    {
        public static void Map(this ModelBuilder modelBuilder, IModelBuilderMap config)
        {
            config.Map(modelBuilder);
        }
    }
}
