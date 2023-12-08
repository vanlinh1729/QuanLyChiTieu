using System;
using System.ComponentModel.DataAnnotations;
using QuanLyChiTieuCaNhan.Transactions;

namespace QuanLyChiTieuCaNhan.Web.Pages.Transactions.Transaction.ViewModels;

public class CreateEditTransactionViewModel
{
    [Display(Name = "TransactionTransactionType")]
    public TransactionType TransactionType { get; set; }

    [Display(Name = "TransactionCategoryId")]
    public Guid CategoryId { get; set; }

    [Display(Name = "TransactionMoney")]
    public decimal Money { get; set; }
}
