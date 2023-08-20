using Backend.Financeiro.Domain.Entities.Systems.Transactions;
using Backend.Financeiro.Domain.Interfaces.Generics;


namespace Backend.Financeiro.Domain.Interfaces.Systems.Transactions
{
    public interface ITransactionRepository : IRepositoryBase<Transaction>
    {
        Task<IList<Transaction>> ListTransactionUser(string userEmail);

        Task<IList<Transaction>> ListUnPaidExpensesPreviousMonthUser(string userEmail);
    }
}
