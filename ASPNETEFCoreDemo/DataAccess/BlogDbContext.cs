using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccess
{
    public class BlogDbContext : DbContext
    {
        private readonly string _connectionString;
        public BlogDbContext(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public DbSet<Blog> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this._connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API entity mapping
            modelBuilder.Entity<Blog>().ToTable("blog", "dbo");
        }
    }
}
