using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using QuanLyChiTieuCaNhan.Categories.Dtos;
using QuanLyChiTieuCaNhan.Permissions;
using QuanLyChiTieuCaNhan.Transactions;
using QuanLyChiTieuCaNhan.Transactions.Dtos;
using QuanLyChiTieuCaNhan.Wallets.Dtos;
using Volo.Abp.Application.Services;

namespace QuanLyChiTieuCaNhan.Wallets;


public class WalletAppService : CrudAppService<Wallet, WalletDto, Guid, WalletGetListInput, CreateUpdateWalletDto,
        CreateUpdateWalletDto>,
    IWalletAppService
{
    protected override string GetPolicyName { get; set; } = QuanLyChiTieuCaNhanPermissions.Wallet.Default;
    protected override string GetListPolicyName { get; set; } = QuanLyChiTieuCaNhanPermissions.Wallet.Default;
    protected override string CreatePolicyName { get; set; } = QuanLyChiTieuCaNhanPermissions.Wallet.Create;
    protected override string UpdatePolicyName { get; set; } = QuanLyChiTieuCaNhanPermissions.Wallet.Update;
    protected override string DeletePolicyName { get; set; } = QuanLyChiTieuCaNhanPermissions.Wallet.Delete;

    private readonly IWalletRepository _repository;
    private readonly ITransactionRepository _transactionRepository;

    public WalletAppService(IWalletRepository repository, ITransactionRepository transactionRepository) : base(repository)
    {
        _transactionRepository = transactionRepository;
        _repository = repository;
    }

    protected override async Task<IQueryable<Wallet>> CreateFilteredQueryAsync(WalletGetListInput input)
    {
        // TODO: AbpHelper generated
        return (await base.CreateFilteredQueryAsync(input))
            .WhereIf(!input.Name.IsNullOrWhiteSpace(), x => x.Name.Contains(input.Name))
            .WhereIf(!input.Description.IsNullOrWhiteSpace(), x => x.Description.Contains(input.Description))
            .WhereIf(input.MyMoney != null, x => x.MyMoney == input.MyMoney)
            ;
    }

    public async Task<List<WalletWithNameDto>> GetListWalletNameAsync()
    {
        var query = from wallet in await _repository.GetQueryableAsync()
            select new
            {
                Id = wallet.Id,
                WalletName = wallet.Name
            };
        var listwallet = query.ToList();
        var listwalletdto = listwallet.Select(x => new WalletWithNameDto()
        {
            Id = x.Id,
            WalletName = x.WalletName
        }).ToList();
        return listwalletdto;
    }

    public async Task<WalletDto> CreateWalletWithNameAsync(string walletName)
    {
        await _repository.InsertAsync(new Wallet(GuidGenerator.Create(), CurrentTenant.Id, walletName, "", 0));

        return new WalletDto();
    }
   
    
    public async Task<List<CategoryDto>> GetWalletDetailsAsync(Guid id)
    {
        var wallet = (await _repository.WithDetailsAsync(x => x.Categories))
            .Where(x => x.Id == id).FirstOrDefault();

        if (wallet == null)
        {
            return null;
        }

        var listCategories = new List<CategoryDto>();

        foreach (var category in wallet.Categories)
        {
            var transactions = await _transactionRepository.GetListAsync(x => x.CategoryId == category.Id);

            var categoryDto = new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                CategoryType = category.CategoryType,
                Description = category.Description,
                TotalMoney = category.TotalMoney,
                WalletId = category.WalletId,
                ListTransactions = transactions.Select(x => new TransactionDto
                {
                    Id = x.Id,
                    Money = x.Money,
                    CategoryId = x.CategoryId,
                    TransactionType = x.TransactionType
                }).ToList()
            };

            listCategories.Add(categoryDto);
        }

        return listCategories;
    }


}
