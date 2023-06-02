using BurgerHUB.Models;
using Microsoft.EntityFrameworkCore;

namespace BurgerHUB.Data.Models
{
    public class DataContext : DbContext
    {
        public DbSet<BurgerMenu> burgerMenus { get; set; }
        public DbSet<BurgerCons> BurgerCons { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<DeliveryMan> deliveryMen { get; set; }
        public DbSet<Ingridient> Ingridients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Supplement> Supplements { get; set; }
        //
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversation", true);
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BurgerMenu>()
                .HasOne(x => x.Supplement)
                .WithOne(x => x.BurgerMenu);
            modelBuilder.Entity<BurgerMenu>()
        .HasOne(bm => bm.Position)
        .WithOne(p => p.BurgerMenu)
        .HasForeignKey<Position>(p => p.IdBurgerMenu);
            modelBuilder.Entity<BurgerMenu>()
        .HasOne(bm => bm.Supplement)
        .WithOne(s => s.BurgerMenu)
        .HasForeignKey<Supplement>(s => s.IdBurgerMenu);

            modelBuilder.Entity<BurgerCons>()
                .HasMany(x => x.Ingridients)
                .WithOne(x => x.BurgerCons);

            modelBuilder.Entity<BurgerCons>()
                .HasOne(x => x.Supplement)
                .WithOne(x => x.BurgerCons);
            modelBuilder.Entity<BurgerCons>()
       .HasOne(bc => bc.Position)
       .WithOne(p => p.BurgerCons)
       .HasForeignKey<Position>(p => p.IdBurgerCons);
            modelBuilder.Entity<BurgerCons>()
       .HasOne(bc => bc.Supplement)
       .WithOne(s => s.BurgerCons)
       .HasForeignKey<Supplement>(s => s.IdBurgerCons);

            modelBuilder.Entity<Client>()
                .HasMany(x => x.OrderHistory)
                .WithOne(x => x.Client);

            modelBuilder.Entity<Client>()
                .HasOne(x => x.Order)
                .WithOne()
                .HasForeignKey<Order>(x => x.IdClient);

            modelBuilder.Entity<Ingridient>()
                .HasOne(x => x.Supplement)
                .WithOne(x => x.Ingridient);
            modelBuilder.Entity<Ingridient>()
        .HasOne(i => i.Supplement)
        .WithOne(s => s.Ingridient)
        .HasForeignKey<Supplement>(s => s.IdIngridient);

            modelBuilder.Entity<Order>()
                .HasOne(x => x.DeliveryMan)
                .WithOne(x => x.Order);

            modelBuilder.Entity<Order>()
                .HasOne(x => x.Payment)
                .WithOne(x => x.Order);

            modelBuilder.Entity<Order>()
                .HasOne(x => x.Position)
                .WithOne(x => x.Order);
            modelBuilder.Entity<Order>()
        .HasOne(o => o.Payment)
        .WithOne(p => p.Order)
        .HasForeignKey<Payment>(p => p.IdOrder);
            modelBuilder.Entity<Order>()
        .HasOne(o => o.Position)
        .WithOne(p => p.Order)
        .HasForeignKey<Position>(p => p.IdOrder);

            modelBuilder.Entity<Position>()
                .HasOne(x => x.BurgerMenu)
                .WithOne(x => x.Position);

            modelBuilder.Entity<Position>()
                .HasOne(x => x.BurgerCons)
                .WithOne(x => x.Position);
            modelBuilder.Entity<DeliveryMan>()
        .HasOne(dm => dm.Order)
        .WithOne(o => o.DeliveryMan)
        .HasForeignKey<Order>(o => o.IdDeliveryMan);
        }
    }
}
