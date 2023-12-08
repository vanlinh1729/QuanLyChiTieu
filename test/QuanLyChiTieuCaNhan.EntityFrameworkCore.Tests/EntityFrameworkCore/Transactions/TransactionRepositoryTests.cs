using System;
using System.Threading.Tasks;
using QuanLyChiTieuCaNhan.Transactions;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace QuanLyChiTieuCaNhan.EntityFrameworkCore.Transactions;

public class TransactionRepositoryTests : QuanLyChiTieuCaNhanEntityFrameworkCoreTestBase
{
    private readonly ITransactionRepository _transactionRepository;

    public TransactionRepositoryTests()
    {
        _transactionRepository = GetRequiredService<ITransactionRepository>();
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
