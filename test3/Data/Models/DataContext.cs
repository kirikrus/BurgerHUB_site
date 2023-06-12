using BurgerHUB.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;
using System.Security;

namespace BurgerHUB.Data.Models
{
    public class DataContext : DbContext
    {
        public DbSet<BurgerMenu> BurgerMenus { get; set; }
        public DbSet<BurgerCons> BurgerCons { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<DeliveryMan> DeliveryMen { get; set; }
        public DbSet<Ingridient> Ingridients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Supplement> Supplements { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
            //AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            //AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversation", true);
            //if (Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
            //{
            //    Database.EnsureCreated(); // Выполнять только для не встроенной базы данных
            //}
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            //optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=BurgerHubData2;Username=postgres;Password=1234");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne(x => x.Client)
                .WithMany(x => x.OrderHistory)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasOne(x => x.DeliveryMan)
                .WithMany(x => x.Order)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasMany(x => x.Positions)
                .WithOne(x => x.Order)
                .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Position>()
            //    .HasOne(x => x.BurgerMenu)
            //    .WithMany(x => x.Positions)
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Position>()
            //    .HasOne(x => x.BurgerCons)
            //    .WithMany(x => x.Positions)
            //    .OnDelete(DeleteBehavior.NoAction);


        }
        
    }
}
