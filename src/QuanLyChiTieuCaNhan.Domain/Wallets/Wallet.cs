using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.VisualBasic;
using QuanLyChiTieuCaNhan.Categories;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace QuanLyChiTieuCaNhan.Wallets;

public class Wallet: FullAuditedAggregateRoot<Guid>, IMultiTenant
{
    public Guid? TenantId { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
    public decimal MyMoney {  get; set; }
    
    public ICollection<Category> Categories { get; set; }

    public Wallet(Guid id, Guid? tenantId, string name, string description, decimal myMoney) : base(id)
    {
        TenantId = tenantId;
        Name = name;
        Description = description;
        MyMoney = myMoney;
        Categories = new Collection<Category>();
    }

    protected Wallet()
    {
    }
}
