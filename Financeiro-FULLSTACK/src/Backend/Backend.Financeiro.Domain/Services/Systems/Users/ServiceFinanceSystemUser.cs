using Backend.Financeiro.Domain.Entities.Systems.Users;
using Backend.Financeiro.Domain.Interfaces.IServices.Systems.Users;
using Backend.Financeiro.Domain.Interfaces.Systems.Users;

namespace Backend.Financeiro.Domain.Services.Systems.Users
{
    public class ServiceFinanceSystemUser : IServiceFinanceSystemUser
    {
        private readonly IFinanceSystemUser _financeSystemUser;
        public ServiceFinanceSystemUser(IFinanceSystemUser financeSystemUser)
        {
            _financeSystemUser = financeSystemUser;
        }
        public async Task RegisterUserSystem(FinanceSystemUser financeSystemUser)
        {
            await _financeSystemUser.Add(financeSystemUser);
        }
    }
}
