using Microsoft.EntityFrameworkCore;
using ApiTuya.Domain.Entities;

namespace ApiTuya.Infrastructure.DbContexts
{
    public partial class ApiTuyaDbContext : DbContext
    {
        public ApiTuyaDbContext()
        {
        }

        public ApiTuyaDbContext(DbContextOptions<ApiTuyaDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Token> Tokens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}