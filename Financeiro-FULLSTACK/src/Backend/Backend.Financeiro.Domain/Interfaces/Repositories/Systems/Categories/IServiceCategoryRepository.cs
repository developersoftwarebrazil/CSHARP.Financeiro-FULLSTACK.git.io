using Backend.Financeiro.Domain.Entities.Categories;

namespace Backend.Financeiro.Domain.Interfaces.Repositories.Systems.Categories
{
    public interface IServiceCategoryRepository
    {
        Task AddCategory(Category category);
        Task UpdateCategory(Category category);
    }
}
