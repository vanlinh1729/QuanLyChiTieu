using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace QuanLyChiTieuCaNhan.Wallets;

public class WalletAppServiceTests : QuanLyChiTieuCaNhanApplicationTestBase
{
    private readonly IWalletAppService _walletAppService;

    public WalletAppServiceTests()
    {
        _walletAppService = GetRequiredService<IWalletAppService>();
    }

    /*
    [Fact]
    public async Task Test1()
    {
        // Arrange

        // Act

        // Assert
    }
    */
}

