using Backend.Financeiro.Domain.Entities.Systems;

namespace Backend.Financeiro.Domain.Interfaces.Services.Systems
{
    public interface IServiceFinanceSystemRepository
    {
        Task AddFinanceSystem(FinanceSystem financeSystem);
        Task UpdateFinanceSystem(FinanceSystem financeSystem);
    }
}
