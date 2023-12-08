using System;
using Volo.Abp.Domain.Repositories;

namespace QuanLyChiTieuCaNhan.Wallets;

public interface IWalletRepository : IRepository<Wallet, Guid>
{
}
