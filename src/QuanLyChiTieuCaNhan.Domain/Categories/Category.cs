using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.VisualBasic;
using QuanLyChiTieuCaNhan.Transactions;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace QuanLyChiTieuCaNhan.Categories;

public class Category: FullAuditedAggregateRoot<Guid>, IMultiTenant
{
    public Guid? TenantId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal TotalMoney { get; set; }
    public Guid WalletId { get; set; }
    public CategoryType CategoryType { get; set; }
    public ICollection<Transaction> Transactions { get; set; }

    public Category(Guid id, Guid? tenantId, string name, string description, decimal totalMoney, Guid walletId, CategoryType categoryType) : base(id)
    {
        TenantId = tenantId;
        Name = name;
        Description = description;
        TotalMoney = totalMoney;
        WalletId = walletId;
        CategoryType = categoryType;
        Transactions = new Collection<Transaction>();
    }

    protected Category()
    {
    }
}
