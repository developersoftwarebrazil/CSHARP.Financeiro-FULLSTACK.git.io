using Backend.Financeiro.Domain.Entities.Systems.Users;

namespace Backend.Financeiro.Domain.Interfaces.Repositories.IServices.Systems.Users
{
    public interface IServiceFinanceSystemUser
    {
        Task RegisterUserSystem(FinanceSystemUser financeSystemUser);
    }
}
