using ApiPeliculas.Data;
using ApiPeliculas.Models;
using ApiPeliculas.Repository.IRepository;

namespace ApiPeliculas.Repository
{
    public class CategoryRepository : ICategoryRespository
    {

        private readonly ApplicationDbContext _db;

        CategoryRepository(ApplicationDbContext db) { 
        _db = db;
        }

        public bool CreateCategory(Category category)
        {
            category.CreationDate = DateTime.Now;
            _db.Categories.Add(category);
            return Save();
        }
        public bool DeleteCategory(Category category)
        {
            _db.Categories.Remove(category);
              return Save();
        }

        public bool ExistCategory(string name)
        {
            return _db.Categories.Any(c => c.Name.ToLower().Trim() == name.ToLower().Trim());
        }

        public bool ExistCategory(int id)
        {
            return _db.Categories.Any(c => c.Id == id);
        }

        public ICollection<Category> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Category GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool UpdateCategory(Category category)
        {
            category.CreationDate = DateTime.Now;
            _db.Categories.Update(category);
            return Save();
        }
    }
}
