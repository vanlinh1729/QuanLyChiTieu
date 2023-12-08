using QuanLyChiTieuCaNhan.Wallets.Dtos;
using QuanLyChiTieuCaNhan.Web.Pages.Wallets.Wallet.ViewModels;
using QuanLyChiTieuCaNhan.Categories.Dtos;
using QuanLyChiTieuCaNhan.Web.Pages.Categories.Category.ViewModels;
using QuanLyChiTieuCaNhan.Transactions.Dtos;
using QuanLyChiTieuCaNhan.Web.Pages.Transactions.Transaction.ViewModels;
using AutoMapper;

namespace QuanLyChiTieuCaNhan.Web;

public class QuanLyChiTieuCaNhanWebAutoMapperProfile : Profile
{
    public QuanLyChiTieuCaNhanWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<WalletDto, CreateEditWalletViewModel>();
        CreateMap<CreateEditWalletViewModel, CreateUpdateWalletDto>();
        CreateMap<CategoryDto, CreateEditCategoryViewModel>();
        CreateMap<CreateEditCategoryViewModel, CreateUpdateCategoryDto>();
        CreateMap<TransactionDto, CreateEditTransactionViewModel>();
        CreateMap<CreateEditTransactionViewModel, CreateUpdateTransactionDto>();
    }
}
