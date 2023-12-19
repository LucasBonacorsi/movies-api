using ApiPeliculas.Models;

namespace ApiPeliculas.Repository.IRepository
{
    public interface ICategoryRespository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        bool ExistCategory(string name);
        bool ExistCategory(int id);
        bool UpdateCategory(Category category);
        bool DeleteCategory(Category category);
        bool Save();
    }
}
