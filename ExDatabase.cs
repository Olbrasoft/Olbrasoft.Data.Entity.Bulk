using System.Data.Common;
using System.Data.Entity;

namespace Olbrasoft.Data.Entity.Bulk
{
    public static class ExDatabase
    {
        public static DbConnection GetDbConnection(this Database database)
        {
            return database.Connection;
        }

    }
}
