using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using QuanLyChiTieuCaNhan.Wallets.Dtos;
using Volo.Abp.Application.Services;

namespace QuanLyChiTieuCaNhan.Wallets;


public interface IWalletAppService :
    ICrudAppService< 
        WalletDto, 
        Guid, 
        WalletGetListInput,
        CreateUpdateWalletDto,
        CreateUpdateWalletDto>
{

    Task<List<WalletWithNameDto>> GetListWalletNameAsync();
    Task<WalletDto> CreateWalletWithNameAsync(string walletName);
}