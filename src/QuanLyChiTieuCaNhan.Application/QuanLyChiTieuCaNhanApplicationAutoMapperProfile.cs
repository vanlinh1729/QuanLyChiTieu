using QuanLyChiTieuCaNhan.Wallets;
using QuanLyChiTieuCaNhan.Wallets.Dtos;
using QuanLyChiTieuCaNhan.Categories;
using QuanLyChiTieuCaNhan.Categories.Dtos;
using QuanLyChiTieuCaNhan.Transactions;
using QuanLyChiTieuCaNhan.Transactions.Dtos;
using AutoMapper;

namespace QuanLyChiTieuCaNhan;

public class QuanLyChiTieuCaNhanApplicationAutoMapperProfile : Profile
{
    public QuanLyChiTieuCaNhanApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Wallet, WalletDto>();
        CreateMap<CreateUpdateWalletDto, Wallet>(MemberList.Source);
        CreateMap<Category, CategoryDto>();
        CreateMap<CreateUpdateCategoryDto, Category>(MemberList.Source);
        CreateMap<Transaction, TransactionDto>();
        CreateMap<CreateUpdateTransactionDto, Transaction>(MemberList.Source);
    }
}
