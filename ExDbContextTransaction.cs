using System.Data.Common;
using System.Data.Entity;

namespace Olbrasoft.Data.Entity.Bulk
{
    public static class ExDbContextTransaction
    {
        public static DbTransaction GetDbTransaction(this DbContextTransaction transaction)
        {
            return transaction.UnderlyingTransaction;

        }
    }
}
