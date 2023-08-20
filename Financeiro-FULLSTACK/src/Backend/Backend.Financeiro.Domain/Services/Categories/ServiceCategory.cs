using Backend.Financeiro.Domain.Entities.Categories;
using Backend.Financeiro.Domain.Interfaces.Categories;
using Backend.Financeiro.Domain.Interfaces.IServices.Categories;

namespace Backend.Financeiro.Domain.Services.Categories
{
    public class ServiceCategory : IServiceCategory
    {
        private readonly ICategoryRepository _category;
        public ServiceCategory(ICategoryRepository category)
        {
            _category = category;
        }
        public async Task AddCategory(Category category)
        {
            var isValid = category.ValidatePropertyString(category.Name, "Name");
            if (isValid)
            {
                await _category.Add(category);
            }
        }

        public async Task UpdateCategory(Category category)
        {
            var isValid = category.ValidatePropertyString(category.Name, "Name");
            if (!isValid)
            {
                await _category.Update(category);
            }
        }
    }
}
