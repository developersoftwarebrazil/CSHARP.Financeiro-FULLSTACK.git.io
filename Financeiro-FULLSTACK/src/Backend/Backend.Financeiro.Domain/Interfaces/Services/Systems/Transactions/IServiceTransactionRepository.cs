using Backend.Financeiro.Domain.Entities.Systems.Transactions;

namespace Backend.Financeiro.Domain.Interfaces.Services.Systems.Transactions
{
    public interface IServiceTransactionRepository
    {
        Task AddTransaction(Transaction transaction);
        Task UpdateTransaction(Transaction transaction);
        Task<object> GraphicLoad(string userEmail);
    }
}
