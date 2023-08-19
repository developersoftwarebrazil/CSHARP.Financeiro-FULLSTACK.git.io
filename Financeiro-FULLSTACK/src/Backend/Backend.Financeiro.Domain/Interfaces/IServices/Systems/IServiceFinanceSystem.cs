using Backend.Financeiro.Domain.Entities.Systems;

namespace Backend.Financeiro.Domain.Interfaces.IServices.Systems
{
    public interface IServiceFinanceSystem
    {
        Task AddFinanceSystem(FinanceSystem financeSystem);
        Task UpdateFinanceSystem(FinanceSystem financeSystem);
    }
}
