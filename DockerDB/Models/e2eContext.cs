using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DockerDB.Models
{
    public partial class e2eContext : DbContext
    {
        public virtual DbSet<Employees> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=UPSDJ\SQLEXPRESS;Database=e2e;user id=sa;password=abc;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
