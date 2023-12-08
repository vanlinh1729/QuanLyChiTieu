using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyChiTieuCaNhan.Transactions;
using QuanLyChiTieuCaNhan.Transactions.Dtos;
using QuanLyChiTieuCaNhan.Web.Pages.Transactions.Transaction.ViewModels;

namespace QuanLyChiTieuCaNhan.Web.Pages.Transactions.Transaction;

public class EditModalModel : QuanLyChiTieuCaNhanPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateEditTransactionViewModel ViewModel { get; set; }

    private readonly ITransactionAppService _service;

    public EditModalModel(ITransactionAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<TransactionDto, CreateEditTransactionViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditTransactionViewModel, CreateUpdateTransactionDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}