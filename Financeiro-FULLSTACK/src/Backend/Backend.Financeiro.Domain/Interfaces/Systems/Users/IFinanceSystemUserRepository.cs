using Backend.Financeiro.Domain.Entities.Systems.Users;
using Backend.Financeiro.Domain.Interfaces.Generics;

namespace Backend.Financeiro.Domain.Interfaces.Systems.Users
{
    public interface IFinanceSystemUserRepository : IRepositoryBase<FinanceSystemUser>
    {
        Task<IList<FinanceSystemUser>> ListarUsuariosSistema(int systemId);

        Task RemoveUsuarios(List<FinanceSystemUser> users);

        Task<FinanceSystemUser> GetUserByEmail(string userEmail);
    }
}
