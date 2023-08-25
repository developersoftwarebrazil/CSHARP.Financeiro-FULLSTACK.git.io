using Backend.Financeiro.Domain.Entities.Systems.Users;
using Backend.Financeiro.Domain.Interfaces.Repositories.Systems.Users;
using Backend.Financeiro.Domain.Interfaces.Services.Systems.Users;

namespace Backend.Financeiro.Domain.Services.Systems.Users
{
    public class ServiceFinanceSystemUser : IServiceFinanceSystemUser
    {
        private readonly IFinanceSystemUserRepository _financeSystemUser;
        public ServiceFinanceSystemUser(IFinanceSystemUserRepository financeSystemUser)
        {
            _financeSystemUser = financeSystemUser;
        }
        public async Task RegisterUserSystem(FinanceSystemUser financeSystemUser)
        {
            await _financeSystemUser.Add(financeSystemUser);
        }
    }
}
