using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyChiTieuCaNhan.Wallets;
using QuanLyChiTieuCaNhan.Wallets.Dtos;
using QuanLyChiTieuCaNhan.Web.Pages.Wallets.Wallet.ViewModels;

namespace QuanLyChiTieuCaNhan.Web.Pages.Wallets.Wallet;

public class ViewWalletDetailModalMModel : QuanLyChiTieuCaNhanPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateEditWalletViewModel ViewModel { get; set; }

    private readonly IWalletAppService _service;

    public ViewWalletDetailModalMModel(IWalletAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<WalletDto, CreateEditWalletViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditWalletViewModel, CreateUpdateWalletDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}