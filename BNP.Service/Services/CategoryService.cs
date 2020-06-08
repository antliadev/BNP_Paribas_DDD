using BNP.Data.Repositories;
using BNP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BNP.Service.Services
{
    public class CategoryService
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoryService(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void AddCategory(Category category)
        {
            _categoryRepository.Add(category);
        }

        public IEnumerable<Category> FetchCategory()
        {
            return _categoryRepository.GetAllNoTracking();
        }

    }
}
