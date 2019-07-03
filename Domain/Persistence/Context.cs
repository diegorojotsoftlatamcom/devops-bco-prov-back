using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Domain.Persistence
{
    public class Context : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Employee>().ToTable("Employees");
            builder.Entity<Employee>().HasKey(p => p.Legajo);
            builder.Entity<Employee>().Property(p => p.Legajo).IsRequired();
            builder.Entity<Employee>().Property(p => p.Dni).IsRequired();
            builder.Entity<Employee>().Property(p => p.Name).IsRequired();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=192.168.200.183;database=Demo;User ID=sa;password=Yukon900;");
            //optionsBuilder.UseSqlServer();
        }
    }
}