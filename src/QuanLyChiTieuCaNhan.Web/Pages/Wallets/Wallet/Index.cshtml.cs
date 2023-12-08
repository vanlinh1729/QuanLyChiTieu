using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace QuanLyChiTieuCaNhan.Web.Pages.Wallets.Wallet;

public class IndexModel : QuanLyChiTieuCaNhanPageModel
{
    public WalletFilterInput WalletFilter { get; set; }
    
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}

public class WalletFilterInput
{
    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "WalletName")]
    public string? Name { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "WalletDescription")]
    public string? Description { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "WalletMyMoney")]
    public decimal? MyMoney { get; set; }
}
