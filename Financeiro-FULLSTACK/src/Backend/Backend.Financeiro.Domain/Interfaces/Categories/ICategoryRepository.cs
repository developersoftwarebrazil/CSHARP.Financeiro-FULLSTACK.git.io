using Backend.Financeiro.Domain.Entities.Categories;
using Backend.Financeiro.Domain.Interfaces.Generics;

namespace Backend.Financeiro.Domain.Interfaces.Categories
{
    public interface ICategoryRepository : IRepositoryBase<Category>
    {
        Task<IList<Category>> ListUserCategory(string userEmail);
    }
}
