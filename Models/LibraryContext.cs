using Microsoft.EntityFrameworkCore;

namespace CoreMVC.Models
{
    public class LibraryContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {  
            optionsBuilder.UseSqlServer
                (@"server=(localdb)\MSSQLLocalDB;database=Library;integrated security=true");
        }
        public DbSet<Author> Authors { get; set; }//TABLE
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
