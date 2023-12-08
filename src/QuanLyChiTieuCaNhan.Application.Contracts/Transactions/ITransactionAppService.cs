using System;
using QuanLyChiTieuCaNhan.Transactions.Dtos;
using Volo.Abp.Application.Services;

namespace QuanLyChiTieuCaNhan.Transactions;


public interface ITransactionAppService :
    ICrudAppService< 
        TransactionDto, 
        Guid, 
        TransactionGetListInput,
        CreateUpdateTransactionDto,
        CreateUpdateTransactionDto>
{

}