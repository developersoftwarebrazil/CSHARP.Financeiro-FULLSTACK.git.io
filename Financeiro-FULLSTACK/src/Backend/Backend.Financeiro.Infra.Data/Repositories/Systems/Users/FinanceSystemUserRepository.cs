using Backend.Financeiro.Domain.Entities.Systems.Users;
using Backend.Financeiro.Domain.Interfaces.Repositories.Systems.Users;
using Backend.Financeiro.Infra.Data.Context;
using Backend.Financeiro.Infra.Data.Repositories.Generics;
using Microsoft.EntityFrameworkCore;

namespace Backend.Financeiro.Infra.Data.Repositories.Systems.Users
{
    public class FinanceSystemUserRepository : RepositoryBase<FinanceSystemUser>, IFinanceSystemUserRepository
    {
        protected DbContextOptions<TransactiondbContext> options;
        public FinanceSystemUserRepository()
        {
            _options = new DbContextOptions<TransactiondbContext>();
        }
        public async Task<FinanceSystemUser> GetUserByEmail(string userEmail)
        {
            using (var data = new TransactiondbContext(_options))
            {
                return await data.FinanceSystemUsers.AsNoTracking().FirstOrDefaultAsync(f => f.UserEmail.Equals(userEmail));

            }
        }

        public async Task RemoveUsuarios(List<FinanceSystemUser> users)
        {
            using (var data = new TransactiondbContext(_options))
            {
                data.FinanceSystemUsers.RemoveRange();
                await data.SaveChangesAsync();
            }
        }
        public async Task<IList<FinanceSystemUser>> ListarUsuariosSistema(int systemId)
        {
            using (var data = new TransactiondbContext(options))
            {
                return await data.FinanceSystemUsers.Where(fsu => fsu.SystemId == systemId).AsNoTracking().ToListAsync();
            }
        }

    }
}
