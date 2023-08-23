using Backend.Financeiro.Domain.Entities.Systems;
using Backend.Financeiro.Domain.Interfaces.Repositories.Systems;
using Backend.Financeiro.Infra.Data.Context;
using Backend.Financeiro.Infra.Data.Repositories.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Financeiro.Infra.Data.Repositories.Systems
{
    public class FinanceSystemRepository : RepositoryBase<FinanceSystem>, IFinanceSystemRepository
    {
        protected DbContextOptions<TransactiondbContext> _options;
        public FinanceSystemRepository()
        {
            _options = new DbContextOptions<TransactiondbContext>();
        }
        public async Task<IList<FinanceSystem>> ListUserSystem(string userEmail)
        {
            using(var data = new TransactiondbContext(_options))
            {
               return await
                    (
                        from fs in data.FinanceSystem
                        join fsu in data.FinanceSystemUsers on fs.Id equals fsu.Id
                        where fsu.UserEmail.Equals(userEmail)
                        select fs
                    )
                    .AsNoTracking().ToListAsync();
                    
            }
        }
    }
}
