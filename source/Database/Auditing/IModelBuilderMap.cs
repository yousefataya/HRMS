using Microsoft.EntityFrameworkCore;

namespace Auditing
{
    internal interface IModelBuilderMap
    {
        void Map(ModelBuilder builder);
    }
}
