using Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dal.Context
{
    public class MainDbContext : DbContext
    {
        /*
        Add-Migration -Name "" -Project "Dal" -StartupProject "Api"
        Update-Database -Project  "Dal" -StartUpProject "Api"
        Remove-Migration -Project "Dal" -StartupProject "Api"
        */
        public MainDbContext(DbContextOptions<MainDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().
                ToTable("User", "dbo");
            modelBuilder.Entity<AccountEntity>().
                ToTable("Account", "dbo").
                HasOne(p=> p.User).
                WithOne(p => p.Account);
        }
        
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<AccountEntity> Accounts { get; set; }

    }
}
