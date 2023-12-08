using System;
using Volo.Abp.Domain.Repositories;

namespace QuanLyChiTieuCaNhan.Transactions;

public interface ITransactionRepository : IRepository<Transaction, Guid>
{
}
