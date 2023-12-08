using System;
using System.Collections.Generic;
using QuanLyChiTieuCaNhan.Permissions;
using QuanLyChiTieuCaNhan.Transactions.Dtos;
using Volo.Abp.Application.Dtos;

namespace QuanLyChiTieuCaNhan.Categories.Dtos;

[Serializable]
public class CategoryDto : FullAuditedEntityDto<Guid>
{
    public string Name { get; set; }

    public string Description { get; set; }

    public decimal TotalMoney { get; set; }

    public Guid WalletId { get; set; }

    public CategoryType CategoryType { get; set; }
    
    public List<TransactionDto> ListTransactions { get; set; }
}