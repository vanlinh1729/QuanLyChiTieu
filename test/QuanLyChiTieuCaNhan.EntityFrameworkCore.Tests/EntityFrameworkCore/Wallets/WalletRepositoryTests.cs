using System;
using System.Threading.Tasks;
using QuanLyChiTieuCaNhan.Wallets;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace QuanLyChiTieuCaNhan.EntityFrameworkCore.Wallets;

public class WalletRepositoryTests : QuanLyChiTieuCaNhanEntityFrameworkCoreTestBase
{
    private readonly IWalletRepository _walletRepository;

    public WalletRepositoryTests()
    {
        _walletRepository = GetRequiredService<IWalletRepository>();
    }

    /*
    [Fact]
    public async Task Test1()
    {
        await WithUnitOfWorkAsync(async () =>
        {
            // Arrange

            // Act

            //Assert
        });
    }
    */
}
