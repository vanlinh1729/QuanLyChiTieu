using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace QuanLyChiTieuCaNhan.Transactions;

public class Transaction: FullAuditedAggregateRoot<Guid>, IMultiTenant
{
    public Guid? TenantId { get; set; }
    public TransactionType TransactionType { get; set; }
    public Guid CategoryId { get; set; }
    public decimal Money { get; set; }

    public Transaction(Guid id, Guid? tenantId, TransactionType transactionType, Guid categoryId, decimal money) : base(id)
    {
        TenantId = tenantId;
        TransactionType = transactionType;
        CategoryId = categoryId;
        Money = money;
    }

    protected Transaction()
    {
    }
}
