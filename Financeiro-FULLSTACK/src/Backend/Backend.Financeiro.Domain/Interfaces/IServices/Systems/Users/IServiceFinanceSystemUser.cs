using Backend.Financeiro.Domain.Entities.Systems.Users;

namespace Backend.Financeiro.Domain.Interfaces.IServices.Systems.Users
{
    public interface IServiceFinanceSystemUser
    {
        Task RegisterUserSystem(FinanceSystemUser financeSystemUser);
    }
}
