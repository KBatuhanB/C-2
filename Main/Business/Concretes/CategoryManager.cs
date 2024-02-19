using Main.Business.Abstract;
using Main.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Business.Concretes
{
    public class CategoryManager:IManager<Category>
    {
        List<Category> categories;
        public CategoryManager()
        {
            Category category = new Category();
            category.CategoryName = "All";
            category.CategoryDescription = "Show all of them";
            category.CategoryId = 999;

            Category category2 = new Category();
            category2.CategoryName = "Programing";
            category2.CategoryDescription = "Show programing language";
            category2.CategoryId = 111;

            categories = new List<Category> { category, category2 };
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public void Add(Category category)
        {
            categories.Add(category);
        }
        public void Remove(Category category)
        {
            categories.Remove(category);
        }
    }
}
