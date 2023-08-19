using Backend.Financeiro.Domain.Entities.Systems;
using Backend.Financeiro.Domain.Interfaces.Generics;

namespace Backend.Financeiro.Domain.Interfaces.Systems
{
    public interface IFinanceSystem : IGeneric<FinanceSystem>
    {
        Task<IList<FinanceSystem>> ListUserSystem(string userEmail);
    }
}
