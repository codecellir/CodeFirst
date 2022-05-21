using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("myPersonTbl");

            modelBuilder.Entity<Person>().HasKey(x => x.Id);

            modelBuilder.Entity<Person>().Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Person>().Property(x => x.Family)
                .HasMaxLength(100);
        }
    }
}
