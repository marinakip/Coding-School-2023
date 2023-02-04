using Microsoft.EntityFrameworkCore;
using Session_16.Model;
using Session_16.Orm.Configurations;

namespace Session_16.Orm.Context
{
    public class AppDbContext : DbContext {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Pet> Pets { get; set; }    
        public DbSet<PetFood> PetFoods { get; set; }    
        public DbSet<Employee> Employees { get; set; }  
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<MonthlyLedger> MonthlyLedgers { get; set; } 
        public DbSet<PetReport> PetReports { get; set; }
        public DbSet<SpecialOffer> SpecialOffers { get; set; }
        public DbSet<TransactionLine> TransactionLines { get; set; }       
                            

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new PetConfiguration());
            modelBuilder.ApplyConfiguration(new PetFoodConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new MonthlyLedgerConfiguration());
            modelBuilder.ApplyConfiguration(new PetReportConfiguration());
            modelBuilder.ApplyConfiguration(new SpecialOfferConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionLineConfiguration());
            base.OnModelCreating(modelBuilder); 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data Source=MARINA-KIPOUROU; Initial Catalog=PetShopDb;Integrated Security=SSPI;" +
                "Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}