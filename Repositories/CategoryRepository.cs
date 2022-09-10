using CoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreMVC.Repositories
{
    public class CategoryRepository
    {
        LibraryContext context = new LibraryContext();


        public List<Category> GetAll()
        {
            return context.Categories.ToList();
        }
        public void Add(Category category)
        {
            var result = context.Entry(category);
            result.State = EntityState.Added;
            context.SaveChanges();
        }
        public void Delete(Category category)
        {
            var result = context.Entry(category);
            result.State = EntityState.Deleted;
            context.SaveChanges();
        }
        public Category GetById(int id)
        {
            return context.Categories.Find(id);
        }
        public void Update(Category category)
        {
            var result = context.Entry(category);
            result.State = EntityState.Modified;
            context.SaveChanges();
        }





    }
}
