using Microsoft.EntityFrameworkCore;
using ShopiOrderingApp.Domain;

namespace ShopiOrderingApp.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Order> Order { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Order>().HasData(
        //        new Order() { }               
        //        );

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
