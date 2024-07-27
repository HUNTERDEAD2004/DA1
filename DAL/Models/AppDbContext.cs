using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
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
                optionsBuilder.UseSqlServer("Server=DESKTOP-PMB8531\\SQLEXPRESS;Database=AppleStore4;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {       
            
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
            //modelBuilder.Entity<ProductApple>().HasData(
            //            new ProductApple { ProductId = Guid.NewGuid(), IphoneIMEI = Guid.NewGuid(), CategoryID = Guid.NewGuid(), SaleID = Guid.NewGuid(), AppleWatchId = Guid.NewGuid(), MacBookIMEI = Guid.NewGuid(), IpadIMEI = Guid.NewGuid(), AirPodId = Guid.NewGuid(), ImacIMEI = Guid.NewGuid(), Name = "Iphone 15", Price = 20000000, BuyingPrice = 15000000, Description = "Là một sản phẩm chất lượng với cải tiến vượt bậc", OperatingSystem = "IOS", BatteryCapacity = "5000maPH", Weight = 2, YearOfManufacture = DateTime.Now, Material = "Nhựa PVC cao cấp", Origin = "EU", Color = "Đỏ", Quantity = 50, status = 1, Version = "IP.v.1.0.13", CreateBy = "aaa", CreateAt = DateTime.Now, UpdateAt = DateTime.Now, UpdateBy = "" });
            // FK & Seeding UserRole
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
            //    var customer1Id = Guid.NewGuid();
            //    var customer2Id = Guid.NewGuid();

            //    // GUID cố định cho sản phẩm
            //    var product1Id = Guid.NewGuid();
            //    var product2Id = Guid.NewGuid();

            //    // GUID cố định cho đơn hàng
            //    var oder1Id = Guid.NewGuid();
            //    var oder2Id = Guid.NewGuid();
            //    modelBuilder.Entity<Customer>().HasData(
            //    new Customer
            //    {
            //        CustomerID = Guid.NewGuid(),
            //        Name = "John Doe",
            //        Age = 30,
            //        Email = "john.doe@example.com",
            //        Number = "1234567890",
            //        Gender = "Male",
            //        Point = 100,
            //        Status = 1,
            //        CreateAt = DateTime.Now,
            //        UpdateAt = DateTime.Now,
            //        CreateBy = "Admin",
            //        UpdateBy = "Admin"
            //    },
            //    new Customer
            //    {
            //        CustomerID = Guid.NewGuid(),
            //        Name = "Jane Smith",
            //        Age = 28,
            //        Email = "jane.smith@example.com",
            //        Number = "0987654321",
            //        Gender = "Female",
            //        Point = 200,
            //        Status = 1,
            //        CreateAt = DateTime.Now,
            //        UpdateAt = DateTime.Now,
            //        CreateBy = "Admin",
            //        UpdateBy = "Admin"
            //    }
            //);

            //    modelBuilder.Entity<Oder>().HasData(
            //        new Oder
            //        {
            //            OderID = Guid.NewGuid(),
            //            UserID = Guid.NewGuid(),  // Thay thế bằng UserID có sẵn nếu có
            //            CustomerID = Guid.NewGuid(),  // Sử dụng ID của khách hàng vừa tạo
            //            Quantity = 2,
            //            Price = 500.00,
            //            TotalPrice = 1000.00,
            //            Status = 1,
            //            CreateAt = DateTime.Now,
            //            UpdateAt = DateTime.Now,
            //            CreateBy = "Admin",
            //            UpdateBy = "Admin"
            //        });
            //    new Oder
            //    {
            //        OderID = Guid.NewGuid(),
            //        UserID = Guid.NewGuid(),  // Thay thế bằng UserID có sẵn nếu có
            //        CustomerID = customer2Id,  // Sử dụng ID của khách hàng vừa tạo
            //        Quantity = 1,
            //        Price = 800.00,
            //        TotalPrice = 800.00,
            //        Status = 1,
            //        CreateAt = DateTime.Now,
            //        UpdateAt = DateTime.Now,
            //        CreateBy = "Admin",
            //        UpdateBy = "Admin"
            //    };
            //    //
            //    modelBuilder.Entity<OderDetail>().HasData(
            //    new OderDetail
            //    {
            //        OrderDetailsID = Guid.NewGuid(),
            //        ProductId = product1Id,
            //        OderID = oder1Id,
            //        CreateAt = DateTime.Now,
            //        UpdateAt = DateTime.Now,
            //        CreateBy = "Admin",
            //        UpdateBy = "Admin"
            //    },
            //    new OderDetail
            //    {
            //        OrderDetailsID = Guid.NewGuid(),
            //        ProductId = product2Id,
            //        OderID = oder2Id,
            //        CreateAt = DateTime.Now,
            //        UpdateAt = DateTime.Now,
            //        CreateBy = "Admin",
            //        UpdateBy = "Admin"
            //    });
            base.OnModelCreating(modelBuilder);
        }
    }
}
