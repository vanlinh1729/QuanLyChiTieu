using System;
using System.Linq;
using System.Threading.Tasks;
using QuanLyChiTieuCaNhan.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace QuanLyChiTieuCaNhan.Wallets;

public class WalletRepository : EfCoreRepository<QuanLyChiTieuCaNhanDbContext, Wallet, Guid>, IWalletRepository
{
    public WalletRepository(IDbContextProvider<QuanLyChiTieuCaNhanDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Wallet>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}