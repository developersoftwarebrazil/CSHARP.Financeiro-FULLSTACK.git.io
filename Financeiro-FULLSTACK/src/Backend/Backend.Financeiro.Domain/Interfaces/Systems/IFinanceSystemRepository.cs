using Backend.Financeiro.Domain.Entities.Systems;
using Backend.Financeiro.Domain.Interfaces.Generics;

namespace Backend.Financeiro.Domain.Interfaces.Systems
{
    public interface IFinanceSystemRepository : IRepositoryBase<FinanceSystem>
    {

        Task<IList<FinanceSystem>> ListUserSystem(string userEmail);
    }
}
