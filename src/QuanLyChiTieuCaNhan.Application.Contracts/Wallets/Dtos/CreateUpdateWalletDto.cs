using System;

namespace QuanLyChiTieuCaNhan.Wallets.Dtos;

[Serializable]
public class CreateUpdateWalletDto
{
    public string Name { get; set; }

    public string Description { get; set; }

    public decimal MyMoney { get; set; }
}