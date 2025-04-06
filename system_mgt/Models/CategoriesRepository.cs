using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace system_mgt.Models
{
    public class CategoriesRepository
    {
        private static List<Category> _categories = new List<Category>()
        {
            new Category {CategoryId = 1, Name = "Beverage", Description = "Beverages "},
            new Category {CategoryId = 2, Name = "Bakery", Description = "Bakery"},
            new Category { CategoryId = 3, Name = "Meat", Description = "Meat" },

        };

        public static void AddCategory(Category category)
        {
            var maxId = _categories.Max(x => x.CategoryId); 
            category.CategoryId = maxId + 1;
            _categories.Add(category);
        }

        public static List<Category> GetCategories() => _categories;

        public static Category? GetCategoryById(int categoryId)
        {
            var category = _categories.FirstOrDefault(x => x.CategoryId == categoryId);
            if (category != null)
            {
                return new Category
                {
                    CategoryId = category.CategoryId,
                    Name = category.Name,
                    Description = category.Description
                };
            }
            return null;
        }

        public static void UpdateCategory(Category category)
        {
            var existingCategory = _categories.FirstOrDefault(x => x.CategoryId == category.CategoryId);
            if (existingCategory != null)
            {
                existingCategory.Name = category.Name;
                existingCategory.Description = category.Description;
            }
        }

        public static void DeleteCategory(int categoryId)
        {
            var category = _categories.FirstOrDefault(x => x.CategoryId == categoryId);
            if (category != null)
            {
                _categories.Remove(category);
            }
        }
        public static void DeleteAllCategories()
        {
            _categories.Clear();
        }
    }
}