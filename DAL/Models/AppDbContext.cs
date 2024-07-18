using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Accessory> Accessorys { get; set; }
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
        public DbSet<ProductImage> productImages { get; set; }
        public DbSet<ProductVoucher> productVouchers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> userRoles { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
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
                optionsBuilder.UseSqlServer("Data Source= PHUC\\SQLEXPRESS ;Database=AppleStore;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // FK Accessory
            modelBuilder.Entity<Accessory>(entity =>
            {
                entity.HasOne( a => a.Product)
                            .WithMany() //
                            .HasForeignKey( a => a.ProductId )
                            .OnDelete(DeleteBehavior.Restrict);
            });
            //Fk airpod
            modelBuilder.Entity<AirPod>(entity =>
            {
                entity.HasOne(a => a.Product)
                            .WithMany() //
                            .HasForeignKey(a => a.ProductId)
                            .OnDelete(DeleteBehavior.Restrict);
            });
            // Fk applewatch
            modelBuilder.Entity<AppleWatch>(entity =>
            {
                entity.HasOne(a => a.Product)
                            .WithMany() //
                            .HasForeignKey(a => a.ProductId)
                            .OnDelete(DeleteBehavior.Restrict);
            });
            // Fk imac
            modelBuilder.Entity<Imac>(entity =>
            {
                entity.HasOne(a => a.Product)
                            .WithMany() //
                            .HasForeignKey(a => a.ProductId)
                            .OnDelete(DeleteBehavior.Restrict);
            });
            // Fk ipad
            modelBuilder.Entity<Ipad>(entity =>
            {
                entity.HasOne(a => a.Product)
                            .WithMany() //
                            .HasForeignKey(a => a.ProductId)
                            .OnDelete(DeleteBehavior.Restrict);
            });
            // Fk iphone
            modelBuilder.Entity<Iphone>(entity =>
            {
                entity.HasOne(a => a.Product)
                            .WithMany() //
                            .HasForeignKey(a => a.ProductId)
                            .OnDelete(DeleteBehavior.Restrict);
            });
            // Fk macbook
            modelBuilder.Entity<MacBook>(entity =>
            {
                entity.HasOne(a => a.Product)
                            .WithMany() //
                            .HasForeignKey(a => a.ProductId)
                            .OnDelete(DeleteBehavior.Restrict);
            });
            //Fk Oder
            modelBuilder.Entity<Oder>(entity =>
            {
                entity.HasOne(a => a.User)
                            .WithMany() //
                            .HasForeignKey(a => a.UserID)
                            .OnDelete(DeleteBehavior.Restrict);
            });
            ////Fk OderDetail
            modelBuilder.Entity<OderDetail>(entity =>
            {
                entity.HasOne(a => a.Product)
                            .WithMany() 
                            .HasForeignKey(a => a.ProductId)
                            .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(b => b.Oder)
                            .WithMany()
                            .HasForeignKey(b => b.OderID)
                            .OnDelete(DeleteBehavior.Restrict);
            });
            //fk Product
            modelBuilder.Entity<ProductApple>(entity =>
            {
                entity.HasOne(b => b.Category)
                            .WithMany()
                            .HasForeignKey(b => b.CategoryID)
                            .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.HasOne(b => b.Product)
                            .WithMany()
                            .HasForeignKey(b => b.ProductId)
                            .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<ProductVoucher>(entity =>
            {
                entity.HasOne(a => a.Product)
                            .WithMany() 
                            .HasForeignKey(a => a.ProductId)
                            .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(b => b.Voucher)
                            .WithMany()
                            .HasForeignKey(b => b.VoucherID)
                            .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasOne(a => a.User)
                            .WithMany() 
                            .HasForeignKey(a => a.UserID)
                            .HasConstraintName("FK_UserRoles_Users_UserID")
                            .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(b => b.Role)
                            .WithMany()
                            .HasForeignKey(b => b.RoleId)
                            .HasConstraintName("FK_UserRoles_Roles_RoleID")
                            .OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<Warranty>(entity =>
            {
                entity.HasOne(a => a.Product)
                            .WithMany() 
                            .HasForeignKey(a => a.ProductId)

                            .OnDelete(DeleteBehavior.Restrict);               
            });
            base.OnModelCreating(modelBuilder);

        }
    }
}
