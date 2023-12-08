using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace QuanLyChiTieuCaNhan.Transactions.Dtos;

[Serializable]
public class TransactionGetListInput : PagedAndSortedResultRequestDto
{
    public TransactionType? TransactionType { get; set; }

    public Guid? CategoryId { get; set; }

    public decimal? Money { get; set; }
}