﻿using Backend.Financeiro.Domain.Entities.Categories;
using Backend.Financeiro.Domain.Interfaces.Repositories.Categories;
using Backend.Financeiro.Domain.Interfaces.Repositories.Systems.Categories;

namespace Backend.Financeiro.Domain.Services.Categories
{
    public class ServiceCategory : IServiceCategoryRepository
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
