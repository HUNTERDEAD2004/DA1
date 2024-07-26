using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAL.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Accessory> accessories { get; set; }

        public DbSet<AirPod> AirPods { get; set; }

        public DbSet<AppleWatch> AppleWatches { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Imac> Imacs { get; set; }

        public DbSet<Ipad> Ipads { get; set; }

        public DbSet<Iphone> Iphones { get; set; }

        public DbSet<MacBook> MacBooks { get; set; }

        public DbSet<Oder> Oders { get; set; }

        public DbSet<OderDetail> oderDetails { get; set; }

        public DbSet<ProductApple> productApples { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserRole> userRoles { get; set; }

        public DbSet<Customer> customers { get; set; }

        public DbSet<Sale> sales { get; set; }

        public DbSet<Warranty> warranties { get; set; }

        public AppDbContext()
        {
                
        }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOPD-DELLIN\\SQLEXPRESS;Database=appstore;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //FK & Seed Accessorry 
            modelBuilder.Entity<Accessory>(entity =>
            {
                entity.HasOne( a => a.Product)
                            .WithMany(p => p.Accessorys) 
                            .HasForeignKey( a => a.ProductId )
                            .OnDelete(DeleteBehavior.Restrict);
            });
            //Fk & Seeding airpod
            modelBuilder.Entity<AirPod>(entity => 
            {
                entity.HasOne(a => a.Product)
                            .WithOne(p => p.AirPod)
                            .HasForeignKey<ProductApple>(a => a.ProductId)
                            .OnDelete(DeleteBehavior.Restrict);
            });
            //Fk & Seeding applewatch
            modelBuilder.Entity<AppleWatch>(entity =>
            {
                entity.HasOne(a => a.Product)
                            .WithOne(p => p.AppleWatch)
                            .HasForeignKey<ProductApple>(a => a.ProductId)
                            .OnDelete(DeleteBehavior.Restrict);
            });
            //Fk & Seeding imac
            modelBuilder.Entity<Imac>(entity =>
            {
                entity.HasOne(a => a.Product)
                            .WithOne(p => p.Imac)
                            .HasForeignKey<ProductApple>(a => a.ProductId)
                            .OnDelete(DeleteBehavior.Restrict);
            });
            //FK & Seeding ipad
            modelBuilder.Entity<Ipad>(entity =>
            {
                entity.HasOne(a => a.Product)
                            .WithOne(p => p.Ipad)
                            .HasForeignKey<ProductApple>(a => a.ProductId)
                            .OnDelete(DeleteBehavior.Restrict);
            });
            //Fk & Seeding iphone
            modelBuilder.Entity<Iphone>(entity =>
            {
                entity.HasOne(a => a.Product)
                            .WithOne(p => p.Iphone)
                            .HasForeignKey<ProductApple>(a => a.ProductId)
                            .OnDelete(DeleteBehavior.Restrict);
            });
            //FK & Seeding macbook
            modelBuilder.Entity<MacBook>(entity =>
            {
                entity.HasOne(a => a.Product)
                            .WithOne(p => p.MacBook)
                            .HasForeignKey<ProductApple>(a => a.ProductId)
                            .OnDelete(DeleteBehavior.Restrict);
            });
            //Fk & Seeding Oder
            modelBuilder.Entity<Oder>(entity =>
            {
                entity.HasOne(a => a.User)
                            .WithMany(p => p.Oders) 
                            .HasForeignKey(a => a.UserID)
                            .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(a => a.Customer)
                            .WithMany(p => p.Oders) 
                            .HasForeignKey(a => a.CustomerID)
                            .OnDelete(DeleteBehavior.Restrict);
            });
            ////Fk & Seeding OderDetail
            modelBuilder.Entity<OderDetail>(entity =>
            {
                entity.HasOne(a => a.Product)
                            .WithMany(p => p.OderDetails) 
                            .HasForeignKey(a => a.ProductId)
                            .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(b => b.Oder)
                            .WithMany(p => p.OderDetails)
                            .HasForeignKey(b => b.OderID)
                            .OnDelete(DeleteBehavior.Restrict);
            });
            //FK & Seeding Product
            modelBuilder.Entity<ProductApple>(entity =>
            {
                entity.HasOne(b => b.Category)
                            .WithMany(p => p.ProductApples)
                            .HasForeignKey(b => b.CategoryID)
                            .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(b => b.Sale)
                            .WithMany(p => p.ProductApples)
                            .HasForeignKey(b => b.SaleID)
                            .OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<ProductApple>().HasData(
                        new ProductApple { ProductId = Guid.NewGuid(), IphoneIMEI = Guid.NewGuid(), CategoryID = Guid.NewGuid(), SaleID = Guid.NewGuid(), AppleWatchId = Guid.NewGuid(), MacBookIMEI = Guid.NewGuid(), IpadIMEI = Guid.NewGuid(), AirPodId = Guid.NewGuid(), ImacIMEI = Guid.NewGuid(), Name = "Iphone 15", Price = 20000000, BuyingPrice = 15000000, Description = "Là một sản phẩm chất lượng với cải tiến vượt bậc", OperatingSystem = "IOS", BatteryCapacity = "5000maPH", Weight = 2, YearOfManufacture = DateTime.Now, Material = "Nhựa PVC cao cấp", Origin = "EU", Color = "Đỏ", Quantity = 50, status = 1, Version = "IP.v.1.0.13", CreateBy = "aaa", CreateAt = DateTime.Now, UpdateAt = DateTime.Now, UpdateBy = "" });
            //FK & Seeding UserRole
            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasOne(a => a.User)
                            .WithMany(p => p.UserRoles) 
                            .HasForeignKey(a => a.UserID)
                            .HasConstraintName("FK_UserRoles_Users_UserID")
                            .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(b => b.Role)
                            .WithMany(p => p.UserRoles)
                            .HasForeignKey(b => b.RoleID)
                            .HasConstraintName("FK_UserRoles_Roles_RoleID")
                            .OnDelete(DeleteBehavior.Restrict);
            });
            //FK & Seeding Warranty
            modelBuilder.Entity<Warranty>(entity =>
            {
                entity.HasOne(a => a.Product)
                            .WithMany(p => p.Warranties) 
                            .HasForeignKey(a => a.ProductId)

                            .OnDelete(DeleteBehavior.Restrict);
            });
            //modelBuilder.Entity<Warranty>().HasData(
            //    new Warranty { WarrantyId = Guid.NewGuid(), ProductId = Guid.NewGuid(), StartDate = DateTime.Now, EndDate = DateTime.Now, Terms = "aa", CreateBy = "aaa", CreateAt = DateTime.Now, UpdateAt = DateTime.Now, UpdateBy = "13" },
            //    new Warranty { WarrantyId = Guid.NewGuid(), ProductId = Guid.NewGuid(), StartDate = DateTime.Now, EndDate = DateTime.Now, Terms = "aa", CreateBy = "aaa", CreateAt = DateTime.Now, UpdateAt = DateTime.Now, UpdateBy = "13" },
            //    new Warranty { WarrantyId = Guid.NewGuid(), ProductId = Guid.NewGuid(), StartDate = DateTime.Now, EndDate = DateTime.Now, Terms = "aa", CreateBy = "aaa", CreateAt = DateTime.Now, UpdateAt = DateTime.Now, UpdateBy = "13" }
            //    );
            base.OnModelCreating(modelBuilder);
        }
    }
}
