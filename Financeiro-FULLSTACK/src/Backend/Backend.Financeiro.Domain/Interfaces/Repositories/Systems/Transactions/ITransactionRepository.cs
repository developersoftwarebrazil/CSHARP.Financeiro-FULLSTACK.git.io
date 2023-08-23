using Backend.Financeiro.Domain.Entities.Systems.Transactions;
using Backend.Financeiro.Domain.Interfaces.Repositories.Generics;

namespace Backend.Financeiro.Domain.Interfaces.Repositories.Systems.Transactions
{
    public interface ITransactionRepository : IRepositoryBase<Transaction>
    {
        Task<IList<Transaction>> ListTransactionUser(string userEmail);

        Task<IList<Transaction>> ListUnPaidExpensesPreviousMonthUser(string userEmail);
    }
}
