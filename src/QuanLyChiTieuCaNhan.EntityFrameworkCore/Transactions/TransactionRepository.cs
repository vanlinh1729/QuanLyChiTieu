using System;
using System.Linq;
using System.Threading.Tasks;
using QuanLyChiTieuCaNhan.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace QuanLyChiTieuCaNhan.Transactions;

public class TransactionRepository : EfCoreRepository<QuanLyChiTieuCaNhanDbContext, Transaction, Guid>, ITransactionRepository
{
    public TransactionRepository(IDbContextProvider<QuanLyChiTieuCaNhanDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Transaction>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}