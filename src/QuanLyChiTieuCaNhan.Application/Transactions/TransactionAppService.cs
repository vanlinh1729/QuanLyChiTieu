using System;
using System.Linq;
using System.Threading.Tasks;
using QuanLyChiTieuCaNhan.Permissions;
using QuanLyChiTieuCaNhan.Transactions.Dtos;
using Volo.Abp.Application.Services;

namespace QuanLyChiTieuCaNhan.Transactions;


public class TransactionAppService : CrudAppService<Transaction, TransactionDto, Guid, TransactionGetListInput, CreateUpdateTransactionDto, CreateUpdateTransactionDto>,
    ITransactionAppService
{
    protected override string GetPolicyName { get; set; } = QuanLyChiTieuCaNhanPermissions.Transaction.Default;
    protected override string GetListPolicyName { get; set; } = QuanLyChiTieuCaNhanPermissions.Transaction.Default;
    protected override string CreatePolicyName { get; set; } = QuanLyChiTieuCaNhanPermissions.Transaction.Create;
    protected override string UpdatePolicyName { get; set; } = QuanLyChiTieuCaNhanPermissions.Transaction.Update;
    protected override string DeletePolicyName { get; set; } = QuanLyChiTieuCaNhanPermissions.Transaction.Delete;

    private readonly ITransactionRepository _repository;

    public TransactionAppService(ITransactionRepository repository) : base(repository)
    {
        _repository = repository;
    }

    protected override async Task<IQueryable<Transaction>> CreateFilteredQueryAsync(TransactionGetListInput input)
    {
        // TODO: AbpHelper generated
        return (await base.CreateFilteredQueryAsync(input))
            .WhereIf(input.TransactionType != null, x => x.TransactionType == input.TransactionType)
            .WhereIf(input.CategoryId != null, x => x.CategoryId == input.CategoryId)
            .WhereIf(input.Money != null, x => x.Money == input.Money)
            ;
    }
    
}
