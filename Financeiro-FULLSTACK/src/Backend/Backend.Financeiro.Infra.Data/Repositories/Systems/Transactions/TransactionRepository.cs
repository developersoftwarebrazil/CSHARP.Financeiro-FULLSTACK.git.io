using Backend.Financeiro.Domain.Entities.Systems.Transactions;
using Backend.Financeiro.Domain.Interfaces.Repositories.Systems.Transactions;
using Backend.Financeiro.Infra.Data.Context;
using Backend.Financeiro.Infra.Data.Repositories.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Financeiro.Infra.Data.Repositories.Systems.Transactions
{
    public class TransactionRepository : RepositoryBase<Transaction>, ITransactionRepository
    {
        protected DbContextOptions<TransactiondbContext> _options;
        public TransactionRepository()
        {
            _options = new DbContextOptions<TransactiondbContext>();
        }

        public async Task<IList<Transaction>> ListTransactionUser(string userEmail)
        {
           using(var data = new TransactiondbContext(_options))
            { 
                return await
                (
                from fs in data.FinanceSystem 
                    join c in data.Categories on fs.Id equals c.SystemId
                    join fsu in data.FinanceSystemUsers on fs.Id equals fsu.SystemId
                    join t in data.Transactions on c.Id equals t.CategoryId
                    where fsu.UserEmail.Equals(userEmail) && fs.Month == t.Month && fs.Year == t.Year
                    select t
                ).AsNoTracking().ToListAsync();          
            }
        }

        public async Task<IList<Transaction>> ListUnPaidExpensesPreviousMonthUser(string userEmail)
        {
            using(var data = new TransactiondbContext(_options))
            {
                return await
                    (
                        from fs in data.FinanceSystem
                        join c in data.Categories on fs.Id equals c.SystemId
                        join fsu in data.FinanceSystemUsers on fs.Id equals fsu.SystemId
                        join t in data.Transactions on c.Id equals t.CategoryId
                        where fsu.UserEmail.Equals(userEmail) && t.Month < DateTime.Now.Month && !t.Paid
                        select t
                    ).AsNoTracking().ToListAsync();
            }
        }
    }
}
