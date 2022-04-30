using Microsoft.EntityFrameworkCore;
using Tasks.API.Data.Entities;

namespace Tasks.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Note>().HasIndex(x => x.id).IsUnique();
        }
    }
}
