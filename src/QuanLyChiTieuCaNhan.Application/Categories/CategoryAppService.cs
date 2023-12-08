using System;
using System.Linq;
using System.Threading.Tasks;
using QuanLyChiTieuCaNhan.Permissions;
using QuanLyChiTieuCaNhan.Categories.Dtos;
using Volo.Abp.Application.Services;

namespace QuanLyChiTieuCaNhan.Categories;


public class CategoryAppService : CrudAppService<Category, CategoryDto, Guid, CategoryGetListInput, CreateUpdateCategoryDto, CreateUpdateCategoryDto>,
    ICategoryAppService
{
    protected override string GetPolicyName { get; set; } = QuanLyChiTieuCaNhanPermissions.Category.Default;
    protected override string GetListPolicyName { get; set; } = QuanLyChiTieuCaNhanPermissions.Category.Default;
    protected override string CreatePolicyName { get; set; } = QuanLyChiTieuCaNhanPermissions.Category.Create;
    protected override string UpdatePolicyName { get; set; } = QuanLyChiTieuCaNhanPermissions.Category.Update;
    protected override string DeletePolicyName { get; set; } = QuanLyChiTieuCaNhanPermissions.Category.Delete;

    private readonly ICategoryRepository _repository;

    public CategoryAppService(ICategoryRepository repository) : base(repository)
    {
        _repository = repository;
    }

    protected override async Task<IQueryable<Category>> CreateFilteredQueryAsync(CategoryGetListInput input)
    {
        // TODO: AbpHelper generated
        return (await base.CreateFilteredQueryAsync(input))
            .WhereIf(!input.Name.IsNullOrWhiteSpace(), x => x.Name.Contains(input.Name))
            .WhereIf(!input.Description.IsNullOrWhiteSpace(), x => x.Description.Contains(input.Description))
            .WhereIf(input.TotalMoney != null, x => x.TotalMoney == input.TotalMoney)
            .WhereIf(input.WalletId != null, x => x.WalletId == input.WalletId)
            .WhereIf(input.CategoryType != null, x => x.CategoryType == input.CategoryType)
            ;
    }
}
