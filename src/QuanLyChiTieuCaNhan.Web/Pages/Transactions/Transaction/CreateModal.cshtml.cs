using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyChiTieuCaNhan.Transactions;
using QuanLyChiTieuCaNhan.Transactions.Dtos;
using QuanLyChiTieuCaNhan.Web.Pages.Transactions.Transaction.ViewModels;

namespace QuanLyChiTieuCaNhan.Web.Pages.Transactions.Transaction;

public class CreateModalModel : QuanLyChiTieuCaNhanPageModel
{
    [BindProperty]
    public CreateEditTransactionViewModel ViewModel { get; set; }

    private readonly ITransactionAppService _service;

    public CreateModalModel(ITransactionAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditTransactionViewModel, CreateUpdateTransactionDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}