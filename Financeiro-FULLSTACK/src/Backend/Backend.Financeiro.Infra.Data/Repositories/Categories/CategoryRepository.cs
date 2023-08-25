using Backend.Financeiro.Domain.Entities.Categories;
using Backend.Financeiro.Domain.Interfaces.Repositories.Categories;
using Backend.Financeiro.Infra.Data.Context;
using Backend.Financeiro.Infra.Data.Repositories.Generics;
using Microsoft.EntityFrameworkCore;

namespace Backend.Financeiro.Infra.Data.Repositories.Categories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        protected DbContextOptions<TransactiondbContext> _options;
        public CategoryRepository()
        {
            _options = new DbContextOptions<TransactiondbContext>();
        }
        public async Task<IList<Category>> ListUserCategory(string userEmail)
        {
            using (var data = new TransactiondbContext(_options))
            {
                return await
                    (
                        from fs in data.FinanceSystem
                        join c in data.Categories on fs.Id equals c.SystemId
                        join fsu in data.FinanceSystemUsers on fs.Id equals fsu.SystemId
                        where fsu.UserEmail.Equals(userEmail) && fsu.ActualSystem
                        select c
                    ).AsNoTracking().ToArrayAsync();
            }
        }
    }
}
