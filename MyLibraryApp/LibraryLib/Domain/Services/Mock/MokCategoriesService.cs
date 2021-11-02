using LibraryLib.Domain.Interfaces;
using LibraryLib.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Services.Mock
{
    public class MokCategoriesService : ICategories
    {
        public bool CreateCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public bool CreateCategory(string name)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooksByCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooksByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllCategorie()
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
