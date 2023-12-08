using System;

namespace QuanLyChiTieuCaNhan.Transactions.Dtos;

[Serializable]
public class CreateUpdateTransactionDto
{
    public TransactionType TransactionType { get; set; }

    public Guid CategoryId { get; set; }

    public decimal Money { get; set; }
}