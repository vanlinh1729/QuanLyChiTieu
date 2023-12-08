using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace QuanLyChiTieuCaNhan.Transactions;

public class TransactionAppServiceTests : QuanLyChiTieuCaNhanApplicationTestBase
{
    private readonly ITransactionAppService _transactionAppService;

    public TransactionAppServiceTests()
    {
        _transactionAppService = GetRequiredService<ITransactionAppService>();
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

