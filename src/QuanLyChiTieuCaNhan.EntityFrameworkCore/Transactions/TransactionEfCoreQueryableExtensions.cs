using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace QuanLyChiTieuCaNhan.Transactions;

public static class TransactionEfCoreQueryableExtensions
{
    public static IQueryable<Transaction> IncludeDetails(this IQueryable<Transaction> queryable, bool include = true)
    {
        if (!include)
        {
            return queryable;
        }

        return queryable
            // .Include(x => x.xxx) // TODO: AbpHelper generated
            ;
    }
}
