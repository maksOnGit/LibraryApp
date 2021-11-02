using LibraryLib.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Interfaces
{
    public interface ICategories
    {
        //Create

        bool CreateCategory(Category category);
        bool CreateCategory(string name);

        //Read

        List<Category> GetAllCategorie();
        Category GetCategoryById(int id);
        List<Book> GetAllBooksByCategory(Category category);
        List<Book> GetAllBooksByCategoryId(int id);

        //update
        bool UpdateCategory(Category category);

        //delete
        bool DeleteCategory(Category category);
        bool DeleteCategoryById(int id);
    }
}
