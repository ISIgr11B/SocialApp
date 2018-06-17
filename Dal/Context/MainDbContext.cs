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
            modelBuilder.Entity<UserEntity>().
                HasMany(x => x.Photos).
                WithOne(x => x.User);
            modelBuilder.Entity<UserEntity>().
                HasMany(x => x.Posts).
                WithOne(x => x.User);

            modelBuilder.Entity<UserEntity>().
                HasMany(x => x.Friends).
                WithOne(x => x.User);
            modelBuilder.Entity<UserEntity>().
                HasMany(x => x.IsRelated).
                WithOne(x => x.RelativeUser);

        }
        
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<PhotoEntity> Photos { get; set; }
        public DbSet<PostEntity> Posts { get; set; }
        public DbSet<FriendsEntity> Friends { get; set; }

    }
}
