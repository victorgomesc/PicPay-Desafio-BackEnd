using Microsoft.EntityFrameworkCore.Storage;
using PicPay_Desafio_BackEnd.Models;

namespace PicPay_Desafio_BackEnd.Infra.Repository.Transferencias;

public interface ITransferenciaRepository
{
    Task AddTransaction(TransferenciaEntity entityEntity);

    Task CommitAsync();
    
    Task<IDbContextTransaction> BeginTransactionAsync();
}