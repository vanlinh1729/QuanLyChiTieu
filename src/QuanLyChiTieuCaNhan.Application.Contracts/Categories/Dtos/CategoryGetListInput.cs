using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace QuanLyChiTieuCaNhan.Categories.Dtos;

[Serializable]
public class CategoryGetListInput : PagedAndSortedResultRequestDto
{
    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal? TotalMoney { get; set; }

    public Guid? WalletId { get; set; }

    public CategoryType? CategoryType { get; set; }
}