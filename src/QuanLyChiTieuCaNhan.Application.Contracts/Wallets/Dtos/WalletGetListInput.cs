using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace QuanLyChiTieuCaNhan.Wallets.Dtos;

[Serializable]
public class WalletGetListInput : PagedAndSortedResultRequestDto
{
    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal? MyMoney { get; set; }
}