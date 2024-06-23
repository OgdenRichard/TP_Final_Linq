using Microsoft.EntityFrameworkCore;
using System.Net;

namespace TP_Final_Linq.DAL
{
    public class EatDomicileDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-ODQ7DHB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;Initial Catalog=EAT_DOMICILE");
        }

        public DbSet<Adress> Adresses { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Drink> Drinks { get; set; }

        public DbSet<Food> Foods { get; set; }

        public DbSet<Pasta> Pastas { get; set; }

        public DbSet<Burger> Burgers { get; set; }

        public DbSet<Pizza> Pizzas { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }

        public DbSet<Dough> Doughs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* ------------------- HÉRITAGE TPT ------------------- */

            modelBuilder.Entity<Product>().ToTable("Product");

            modelBuilder.Entity<Drink>().ToTable("Drink");

            modelBuilder.Entity<Food>().ToTable("Food");

            modelBuilder.Entity<Pasta>().ToTable("Pasta");

            // Burger | Renommage de la PK héritée
            modelBuilder.Entity<Burger>()
                .ToTable("Burger", tb => tb
                    .Property(x => x.ProductId)
                    .HasColumnName("BurgerId"));

            // Pizza | Renommage de la PK héritée
            modelBuilder.Entity<Pizza>()
                .ToTable("Pizza", tb => tb
                    .Property(x => x.ProductId)
                    .HasColumnName("PizzaId"));

            /* ---------------------------------------------------- */

            /* -------------------- RELATIONS -------------------- */

            // 0 TO MANY | Burger > Ingredients
            modelBuilder.Entity<Burger>()
                .HasMany(b => b.Ingredients)
                .WithOne(i => i.Burger)
                .HasForeignKey(i => i.BurgerId)
                .OnDelete(DeleteBehavior.NoAction);

            // 0 TO MANY | Pizza > Ingredients
            modelBuilder.Entity<Pizza>()
                .HasMany(p => p.Ingredients)
                .WithOne(i => i.Pizza)
                .HasForeignKey(i => i.PizzaId)
                .OnDelete(DeleteBehavior.NoAction);

            // 0 TO 1 | Doughs > Pizza
            modelBuilder.Entity<Pizza>()
                .HasOne(p => p.Dough);

            // MANY TO MANY | OrderProduct
            modelBuilder.Entity<Order>()
                .HasMany(o => o.Products)
                .WithMany(p => p.Orders)
                .UsingEntity("OrderProduct",
                    l => l.HasOne(typeof(Product))
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .HasPrincipalKey(nameof(Product.ProductId))
                        .OnDelete(DeleteBehavior.NoAction),
                    r => r.HasOne(typeof(Order))
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .HasPrincipalKey(nameof(Order.OrderId))
                        .OnDelete(DeleteBehavior.NoAction)
                        );


            // ONE TO MANY

            modelBuilder.Entity<Adress>()
            .HasMany(a => a.Users)
            .WithOne(l => l.Adresse)
            .HasForeignKey(a => a.AdresseId)
            .IsRequired()
            .OnDelete(DeleteBehavior.NoAction); ;

            modelBuilder.Entity<Adress>()
            .HasMany(a => a.Orders)
            .WithOne(p => p.Adress)
            .HasForeignKey(a => a.DeliveryAddressId)
            .IsRequired()
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
            .HasMany(a => a.Orders)
            .WithOne(p => p.User)
            .IsRequired();

        }

    }
}
