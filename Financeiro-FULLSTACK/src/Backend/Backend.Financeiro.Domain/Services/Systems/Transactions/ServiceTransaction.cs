using Backend.Financeiro.Domain.Entities.Systems.Transactions;
using Backend.Financeiro.Domain.Interfaces.Repositories.Systems.Transactions;
using Backend.Financeiro.Domain.Interfaces.Services.Systems.Transactions;

namespace Backend.Financeiro.Domain.Services.Systems.Transactions
{
    public class ServiceTransaction : IServiceTransactionRepository
    {
        private readonly ITransactionRepository _transactions;
        public ServiceTransaction(ITransactionRepository transactions)
        {
            _transactions = transactions;
        }
        public async Task AddTransaction(Transaction transaction)
        {
            var isValid = transaction.ValidatePropertyString(transaction.Name, "Name");
            var date = DateTime.UtcNow;

            transaction.RegistrationDate = date;
            transaction.Month = date.Month;
            transaction.Year = date.Year;


            if (isValid)
                await _transactions.Add(transaction);
        }

        public async Task UpdateTransaction(Transaction transaction)
        {
            var isValid = transaction.ValidatePropertyString(transaction.Name, "Name");
            var date = DateTime.UtcNow;

            transaction.ChangeDate = date;
            if (transaction.Paid)
            {
                transaction.PayDay = date;
            }

            if (isValid)
            {
                await _transactions.Update(transaction);
            }

        }

        public async Task<object> GraphicLoad(string userEmail)
        {
            var userExpense = await _transactions.ListTransactionUser(userEmail);
            var previousExpense = await _transactions.ListUnPaidExpensesPreviousMonthUser(userEmail);

            var previousMonths_UnPayedExpenses = previousExpense.Any() ? previousExpense.ToList().Sum(x => x.Value) : 0;

            var paid_expenses = userExpense.Where(t => t.Paid && t.TransactionType == Entities.Enums.TransactioEnum.Expense).Sum(x => x.Value);
            var pending_expenses = userExpense.Where(t => t.Paid && t.TransactionType == Entities.Enums.TransactioEnum.Expense).Sum(x => x.Value);


            var investments = userExpense.Where(i => i.TransactionType == Entities.Enums.TransactioEnum.Income).Sum(i => i.Value);


            return new
            {
                success = "OK",
                paid_expenses = paid_expenses,
                pending_expenses = pending_expenses,
                previousMonths_UnPayedExpenses = previousMonths_UnPayedExpenses,
                investments = investments
            };
        }
    }
}
