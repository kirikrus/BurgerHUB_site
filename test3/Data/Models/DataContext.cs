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
        
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
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

            modelBuilder.Entity<Position>()
                .HasOne(x => x.BurgerMenu)
                .WithMany(x => x.Positions)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Position>()
                .HasOne(x => x.BurgerCons)
                .WithMany(x => x.Positions)
                .OnDelete(DeleteBehavior.NoAction);


            //     modelBuilder.Entity<Order>()
            // .HasOne(o => o.Position)
            // .WithOne(p => p.Order)
            // .HasForeignKey<Position>(p => p.IdOrder);
            //     modelBuilder.Entity<Order>()
            // .HasOne(o => o.Client)
            // .WithOne(c => c.Order)
            // .HasForeignKey<Order>(o => o.IdClient);
            //     modelBuilder.Entity<Order>()
            // .HasOne(o => o.Payment)
            // .WithOne(p => p.Order)
            // .HasForeignKey<Order>(o => o.IdPayment);
            //     modelBuilder.Entity<BurgerCons>()
            //.HasOne(bc => bc.Position)
            //.WithOne(p => p.BurgerCons)
            //.HasForeignKey<BurgerCons>(bc => bc.IdPosition);
            //     modelBuilder.Entity<BurgerCons>()
            //  .HasOne(bc => bc.Supplement)
            //  .WithOne(s => s.BurgerCons)
            //  .HasForeignKey<Supplement>(s => s.IdBurgerCons);
            //     modelBuilder.Entity<BurgerMenu>()
            //   .HasOne(bm => bm.Position)
            //   .WithOne(p => p.BurgerMenu)
            //   .HasForeignKey<Position>(p => p.IdBurgerMenu);
            //     modelBuilder.Entity<BurgerMenu>()
            //   .HasOne(bm => bm.Supplement)
            //   .WithOne(s => s.BurgerMenu)
            //   .HasForeignKey<Supplement>(s => s.IdBurgerMenu);
            //     modelBuilder.Entity<DeliveryMan>()
            //   .HasOne(dm => dm.Order)
            //   .WithOne(o => o.DeliveryMan)
            //   .HasForeignKey<Order>(o => o.IdDeliveryMan);
            //     modelBuilder.Entity<Ingridient>()
            //   .HasOne(i => i.Supplement)
            //   .WithOne(s => s.Ingridient)
            //   .HasForeignKey<Supplement>(s => s.IdIngridient);

            /*  modelBuilder.Entity<BurgerMenu>()
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
          .HasOne(i => i.Supplement)
          .WithOne(s => s.Ingridient)
          .HasForeignKey<Supplement>(s => s.IdIngridient);

              modelBuilder.Entity<Order>()
                  .HasOne(x => x.DeliveryMan)
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
            base.OnModelCreating(modelBuilder);*/
        }
        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        
    }
}
