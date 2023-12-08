using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using QuanLyChiTieuCaNhan.Categories;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace QuanLyChiTieuCaNhan.Web.Pages.Categories.Category;

public class IndexModel : QuanLyChiTieuCaNhanPageModel
{
    public CategoryFilterInput CategoryFilter { get; set; }
    
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}

public class CategoryFilterInput
{
    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "CategoryName")]
    public string? Name { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "CategoryDescription")]
    public string? Description { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "CategoryTotalMoney")]
    public decimal? TotalMoney { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "CategoryWalletId")]
    public Guid? WalletId { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "CategoryCategoryType")]
    public CategoryType? CategoryType { get; set; }
}
