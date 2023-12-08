using System;

namespace QuanLyChiTieuCaNhan.Categories.Dtos;

[Serializable]
public class CreateUpdateCategoryDto
{
    public string Name { get; set; }

    public string Description { get; set; }

    public decimal TotalMoney { get; set; }

    public Guid WalletId { get; set; }

    public CategoryType CategoryType { get; set; }
}