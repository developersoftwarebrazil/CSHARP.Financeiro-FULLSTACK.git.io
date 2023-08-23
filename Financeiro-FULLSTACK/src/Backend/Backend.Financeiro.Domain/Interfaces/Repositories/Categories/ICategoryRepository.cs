using Backend.Financeiro.Domain.Entities.Categories;
using Backend.Financeiro.Domain.Interfaces.Repositories.Generics;

namespace Backend.Financeiro.Domain.Interfaces.Repositories.Categories
{
    public interface ICategoryRepository : IRepositoryBase<Category>
    {
        Task<IList<Category>> ListUserCategory(string userEmail);
    }
}
