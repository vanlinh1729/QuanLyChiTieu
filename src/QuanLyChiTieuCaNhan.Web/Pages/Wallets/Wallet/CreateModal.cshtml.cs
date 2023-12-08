using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyChiTieuCaNhan.Wallets;
using QuanLyChiTieuCaNhan.Wallets.Dtos;
using QuanLyChiTieuCaNhan.Web.Pages.Wallets.Wallet.ViewModels;

namespace QuanLyChiTieuCaNhan.Web.Pages.Wallets.Wallet;

public class CreateModalModel : QuanLyChiTieuCaNhanPageModel
{
    [BindProperty]
    public CreateEditWalletViewModel ViewModel { get; set; }

    private readonly IWalletAppService _service;

    public CreateModalModel(IWalletAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditWalletViewModel, CreateUpdateWalletDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}