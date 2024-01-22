using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Infrastructure
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
        : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Child> Child { get; set; }
        public DbSet<Mother> Mother { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Orders)
                .WithOne(o => o.Customer)
                .IsRequired();

            modelBuilder.Entity<Mother>()
                .HasOne(m=>m.Child)
                .WithOne(c=>c.Mother)
                .IsRequired();

            modelBuilder.Entity<Order>(x=> {
                x.ComplexProperty(y => y.ShippingAddress, y => { y.IsRequired(); });
                x.ComplexProperty(y => y.BillingAddress, y => { y.IsRequired(); });
            });





            base.OnModelCreating(modelBuilder);
        }
    }
}
