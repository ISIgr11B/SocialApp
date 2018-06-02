using Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dal.Context
{
    public class MainDbContext : DbContext
    {

        // Add-Migration -Name "" -Project "Dal" -StartupProject "Api"
        // Update-Database -Project  "Dal" -StartUpProject "Api"
        // Remove-Migration -Project "Dal" -StartupProject "Api"
        public MainDbContext(DbContextOptions<MainDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>().
                ToTable("Test", "dbo");
            modelBuilder.Entity<Test>().
                ToTable("User", "dbo");
            modelBuilder.Entity<Test>().
                ToTable("Account", "dbo");
        }

        public DbSet<Test> Tests { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<AccountEntity> Accounts { get; set; }

    }
}
