using System;
using System.ComponentModel.DataAnnotations;
using QuanLyChiTieuCaNhan.Categories;

namespace QuanLyChiTieuCaNhan.Web.Pages.Categories.Category.ViewModels;

public class CreateEditCategoryViewModel
{
    [Display(Name = "CategoryName")]
    public string Name { get; set; }

    [Display(Name = "CategoryDescription")]
    public string Description { get; set; }

    [Display(Name = "CategoryTotalMoney")]
    public decimal TotalMoney { get; set; }

    [Display(Name = "CategoryWalletId")]
    public Guid WalletId { get; set; }

    [Display(Name = "CategoryCategoryType")]
    public CategoryType CategoryType { get; set; }
}
