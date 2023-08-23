using Backend.Financeiro.Domain.Entities.Systems;
using Backend.Financeiro.Domain.Interfaces.Repositories.Generics;

namespace Backend.Financeiro.Domain.Interfaces.Repositories.Systems
{
    public interface IFinanceSystemRepository : IRepositoryBase<FinanceSystem>
    {

        Task<IList<FinanceSystem>> ListUserSystem(string userEmail);
    }
}
