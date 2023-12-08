using System;
using Volo.Abp.Application.Dtos;

namespace QuanLyChiTieuCaNhan.Transactions.Dtos;

[Serializable]
public class TransactionDto : FullAuditedEntityDto<Guid>
{
    public TransactionType TransactionType { get; set; }

    public Guid CategoryId { get; set; }

    public decimal Money { get; set; }
}