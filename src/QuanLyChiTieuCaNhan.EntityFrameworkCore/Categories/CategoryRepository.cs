using System;
using System.Linq;
using System.Threading.Tasks;
using QuanLyChiTieuCaNhan.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace QuanLyChiTieuCaNhan.Categories;

public class CategoryRepository : EfCoreRepository<QuanLyChiTieuCaNhanDbContext, Category, Guid>, ICategoryRepository
{
    public CategoryRepository(IDbContextProvider<QuanLyChiTieuCaNhanDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Category>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}