using Microsoft.EntityFrameworkCore;
using Session_16.Model;

namespace Session_16.Orm.Context
{
    public class AppDbContext : DbContext {

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder); 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            //optionsBuilder.UseSqlServer("Data Source=MARINA-KIPOUROU; Initial Catalog=PetShopDb;Integrated Security=True;" +
            //    "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}