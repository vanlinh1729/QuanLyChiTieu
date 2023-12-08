using System;
using Volo.Abp.Application.Dtos;

namespace QuanLyChiTieuCaNhan.Wallets.Dtos;

[Serializable]
public class WalletDto : FullAuditedEntityDto<Guid>
{
    public string Name { get; set; }

    public string Description { get; set; }

    public decimal MyMoney { get; set; }
}