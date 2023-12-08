using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using QuanLyChiTieuCaNhan.Transactions;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace QuanLyChiTieuCaNhan.Web.Pages.Transactions.Transaction;

public class IndexModel : QuanLyChiTieuCaNhanPageModel
{
    public TransactionFilterInput TransactionFilter { get; set; }
    
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}

public class TransactionFilterInput
{
    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "TransactionTransactionType")]
    public TransactionType? TransactionType { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "TransactionCategoryId")]
    public Guid? CategoryId { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "TransactionMoney")]
    public decimal? Money { get; set; }
}
