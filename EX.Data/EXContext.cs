using EX.Data.Config;
using Microsoft.EntityFrameworkCore;

namespace EX.Data
{
    public class EXContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                                        Initial Catalog = BibliothequeNasriMohamedAmine; 
                                        Integrated Security = true");
            optionsBuilder.UseLazyLoadingProxies(true);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategorieConfig());
            modelBuilder.ApplyConfiguration(new PretLivreConfig());
        }

    }
}