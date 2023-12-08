using System;
using System.ComponentModel.DataAnnotations;

namespace QuanLyChiTieuCaNhan.Web.Pages.Wallets.Wallet.ViewModels;

public class CreateEditWalletViewModel
{
    [Display(Name = "WalletName")]
    public string Name { get; set; }

    [Display(Name = "WalletDescription")]
    public string Description { get; set; }

    [Display(Name = "WalletMyMoney")]
    public decimal MyMoney { get; set; }
}
