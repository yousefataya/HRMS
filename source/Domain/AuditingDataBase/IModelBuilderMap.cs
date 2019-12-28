using Microsoft.EntityFrameworkCore;

namespace AuditingDatabase
{
    internal interface IModelBuilderMap
    {
        void Map(ModelBuilder builder);
    }
}
