using AppData.Config;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class IphoneDbContext : DbContext
    {
        public IphoneDbContext()
        {
            
        }

        public IphoneDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cpu> CPUs { get; set; }
        public DbSet<Ram> RAMs { get; set; }
        public DbSet<Gpu> GPUs { get; set; }
        public DbSet<Rom> ROMs { get; set; }
        public DbSet<Display> Displays { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Statistics> Statistics { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Warranty> Warranties { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Color> Colours { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<OperatingSystems> OperatingSystems { get; set; }
        public DbSet<BatteryCapacity> BatteryCapacities { get; set; }
        public DbSet<Weight> Weights { get; set; }
        public DbSet<YearOfManufacture> YearsOfManufacture { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Origin> Origins { get; set; }
        public DbSet<Versions> Versions { get; set; }
        public DbSet<RearCamera> RearCameras { get; set; }
        public DbSet<CameraSelfie> CameraSelfies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=PHUC\\SQLEXPRESS;Initial Catalog=IphoneNhom1;Integrated Security=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


    }
}
