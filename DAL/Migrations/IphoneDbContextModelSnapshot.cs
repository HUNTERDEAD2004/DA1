﻿// <auto-generated />
using System;
using AppData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(IphoneDbContext))]
    partial class IphoneDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AppData.Models.Account", b =>
                {
                    b.Property<Guid>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BOD")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreateBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Roles")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdateBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Wage")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("AccountID");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("AppData.Models.Color", b =>
                {
                    b.Property<Guid>("ColorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ColorName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ColorID");

                    b.ToTable("Colours");
                });

            modelBuilder.Entity("AppData.Models.Cpu", b =>
                {
                    b.Property<Guid>("CPUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CPUClockSpeed")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("CPUCores")
                        .HasColumnType("int");

                    b.Property<string>("CPUName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("CPUThreads")
                        .HasColumnType("int");

                    b.HasKey("CPUID");

                    b.ToTable("CPUs");
                });

            modelBuilder.Entity("AppData.Models.Customer", b =>
                {
                    b.Property<Guid>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("Age")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("AppData.Models.Display", b =>
                {
                    b.Property<Guid>("DisplayID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("DisplayID");

                    b.ToTable("Displays");
                });

            modelBuilder.Entity("AppData.Models.Gpu", b =>
                {
                    b.Property<Guid>("GPUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GPUMemory")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("GPUName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("GPUID");

                    b.ToTable("GPUs");
                });

            modelBuilder.Entity("AppData.Models.Order", b =>
                {
                    b.Property<Guid>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AccountID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CustomerID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderID");

                    b.HasIndex("AccountID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("AppData.Models.OrderDetail", b =>
                {
                    b.Property<Guid>("OrderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DiscountValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("IMEI")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderDetailID");

                    b.HasIndex("IMEI");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("AppData.Models.Product", b =>
                {
                    b.Property<Guid>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("AppData.Models.ProductDetail", b =>
                {
                    b.Property<Guid>("IMEI")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CPUID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ColorID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DisplayID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GPUID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<Guid>("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RAMID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ROMID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SaleID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IMEI");

                    b.HasIndex("CPUID");

                    b.HasIndex("ColorID");

                    b.HasIndex("DisplayID");

                    b.HasIndex("GPUID");

                    b.HasIndex("ProductID");

                    b.HasIndex("RAMID");

                    b.HasIndex("ROMID");

                    b.HasIndex("SaleID");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("AppData.Models.Ram", b =>
                {
                    b.Property<Guid>("RAMID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RAMSize")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("RAMType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("RAMID");

                    b.ToTable("RAMs");
                });

            modelBuilder.Entity("AppData.Models.Rom", b =>
                {
                    b.Property<Guid>("ROMID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ROMSize")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ROMID");

                    b.ToTable("ROMs");
                });

            modelBuilder.Entity("AppData.Models.Sales", b =>
                {
                    b.Property<Guid>("SaleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DiscountValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SaleDescription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SaleID");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("AppData.Models.Statistics", b =>
                {
                    b.Property<Guid>("StatisticID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("ReportDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalQuantitySold")
                        .HasColumnType("int");

                    b.HasKey("StatisticID");

                    b.HasIndex("ProductID");

                    b.ToTable("Statistics");
                });

            modelBuilder.Entity("AppData.Models.Warranty", b =>
                {
                    b.Property<Guid>("WarrantyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IMEI")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductDetailIMEI")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("WarrantyEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("WarrantyStartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("WarrantyID");

                    b.HasIndex("ProductDetailIMEI");

                    b.ToTable("Warranties");
                });

            modelBuilder.Entity("AppData.Models.Order", b =>
                {
                    b.HasOne("AppData.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppData.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("AppData.Models.OrderDetail", b =>
                {
                    b.HasOne("AppData.Models.ProductDetail", "ProductDetail")
                        .WithMany("OrderDetails")
                        .HasForeignKey("IMEI")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppData.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("AppData.Models.ProductDetail", b =>
                {
                    b.HasOne("AppData.Models.Cpu", "CPU")
                        .WithMany("ProductDetails")
                        .HasForeignKey("CPUID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppData.Models.Color", "Color")
                        .WithMany("ProductDetails")
                        .HasForeignKey("ColorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppData.Models.Display", "Display")
                        .WithMany("ProductDetails")
                        .HasForeignKey("DisplayID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppData.Models.Gpu", "GPU")
                        .WithMany("ProductDetails")
                        .HasForeignKey("GPUID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppData.Models.Product", "Product")
                        .WithMany("ProductDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppData.Models.Ram", "RAM")
                        .WithMany("ProductDetails")
                        .HasForeignKey("RAMID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppData.Models.Rom", "ROM")
                        .WithMany("ProductDetails")
                        .HasForeignKey("ROMID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppData.Models.Sales", "Sale")
                        .WithMany("ProductDetail")
                        .HasForeignKey("SaleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CPU");

                    b.Navigation("Color");

                    b.Navigation("Display");

                    b.Navigation("GPU");

                    b.Navigation("Product");

                    b.Navigation("RAM");

                    b.Navigation("ROM");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("AppData.Models.Statistics", b =>
                {
                    b.HasOne("AppData.Models.Product", "Product")
                        .WithMany("Statistics")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AppData.Models.Warranty", b =>
                {
                    b.HasOne("AppData.Models.ProductDetail", "ProductDetail")
                        .WithMany()
                        .HasForeignKey("ProductDetailIMEI")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("AppData.Models.Color", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("AppData.Models.Cpu", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("AppData.Models.Display", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("AppData.Models.Gpu", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("AppData.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("AppData.Models.Product", b =>
                {
                    b.Navigation("ProductDetails");

                    b.Navigation("Statistics");
                });

            modelBuilder.Entity("AppData.Models.ProductDetail", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("AppData.Models.Ram", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("AppData.Models.Rom", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("AppData.Models.Sales", b =>
                {
                    b.Navigation("ProductDetail");
                });
#pragma warning restore 612, 618
        }
    }
}
