using System;
using System.Threading.Tasks;
using QuanLyChiTieuCaNhan.Categories;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace QuanLyChiTieuCaNhan.EntityFrameworkCore.Categories;

public class CategoryRepositoryTests : QuanLyChiTieuCaNhanEntityFrameworkCoreTestBase
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryRepositoryTests()
    {
        _categoryRepository = GetRequiredService<ICategoryRepository>();
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
