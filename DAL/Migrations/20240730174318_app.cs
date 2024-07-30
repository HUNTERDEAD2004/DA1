using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class app : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Roles = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BOD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountID);
                });

            migrationBuilder.CreateTable(
                name: "BatteryCapacities",
                columns: table => new
                {
                    BatteryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatteryCapacities", x => x.BatteryID);
                });

            migrationBuilder.CreateTable(
                name: "CameraSelfies",
                columns: table => new
                {
                    CameraSelfieID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CameraSelfieDetails = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CameraSelfies", x => x.CameraSelfieID);
                });

            migrationBuilder.CreateTable(
                name: "Colours",
                columns: table => new
                {
                    ColorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ColorName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colours", x => x.ColorID);
                });

            migrationBuilder.CreateTable(
                name: "CPUs",
                columns: table => new
                {
                    CPUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CPUName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CPUCores = table.Column<int>(type: "int", nullable: false),
                    CPUThreads = table.Column<int>(type: "int", nullable: false),
                    CPUClockSpeed = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUs", x => x.CPUID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Age = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Point = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Displays",
                columns: table => new
                {
                    DisplayID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Displays", x => x.DisplayID);
                });

            migrationBuilder.CreateTable(
                name: "GPUs",
                columns: table => new
                {
                    GPUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GPUName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GPUMemory = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPUs", x => x.GPUID);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    MaterialID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterialName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.MaterialID);
                });

            migrationBuilder.CreateTable(
                name: "OperatingSystems",
                columns: table => new
                {
                    OSID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OSName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingSystems", x => x.OSID);
                });

            migrationBuilder.CreateTable(
                name: "Origins",
                columns: table => new
                {
                    OriginID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OriginName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Origins", x => x.OriginID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "RAMs",
                columns: table => new
                {
                    RAMID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RAMSize = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RAMType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAMs", x => x.RAMID);
                });

            migrationBuilder.CreateTable(
                name: "RearCameras",
                columns: table => new
                {
                    RearCameraID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RearCameraDetails = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RearCameras", x => x.RearCameraID);
                });

            migrationBuilder.CreateTable(
                name: "ROMs",
                columns: table => new
                {
                    ROMID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ROMSize = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROMs", x => x.ROMID);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    SaleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SaleDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DiscountValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.SaleID);
                });

            migrationBuilder.CreateTable(
                name: "Versions",
                columns: table => new
                {
                    VersionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VersionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Versions", x => x.VersionID);
                });

            migrationBuilder.CreateTable(
                name: "Vouchers",
                columns: table => new
                {
                    IDVoucher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Expired_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Minium_Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vouchers", x => x.IDVoucher);
                });

            migrationBuilder.CreateTable(
                name: "Warranties",
                columns: table => new
                {
                    WarrantyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WarrantyStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WarrantyEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warranties", x => x.WarrantyID);
                });

            migrationBuilder.CreateTable(
                name: "Weights",
                columns: table => new
                {
                    WeightID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WeightValue = table.Column<float>(type: "real", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weights", x => x.WeightID);
                });

            migrationBuilder.CreateTable(
                name: "YearsOfManufacture",
                columns: table => new
                {
                    YearID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearsOfManufacture", x => x.YearID);
                });

            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    StatisticID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TotalQuantitySold = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.StatisticID);
                    table.ForeignKey(
                        name: "FK_Statistics_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDVoucher = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherIDVoucher = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Accounts",
                        principalColumn: "AccountID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Vouchers_VoucherIDVoucher",
                        column: x => x.VoucherIDVoucher,
                        principalTable: "Vouchers",
                        principalColumn: "IDVoucher",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    IMEI = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WarrantyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    importPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ColorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RAMID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CPUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GPUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ROMID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisplayID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SaleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VoucherIDVoucher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OperatingSystemOSID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BatteryCapacityBatteryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WeightID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    YearOfManufactureYearID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterialID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OriginID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VersionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RearCameraID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CameraSelfieID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.IMEI);
                    table.ForeignKey(
                        name: "FK_ProductDetails_BatteryCapacities_BatteryCapacityBatteryID",
                        column: x => x.BatteryCapacityBatteryID,
                        principalTable: "BatteryCapacities",
                        principalColumn: "BatteryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDetails_CameraSelfies_CameraSelfieID",
                        column: x => x.CameraSelfieID,
                        principalTable: "CameraSelfies",
                        principalColumn: "CameraSelfieID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Colours_ColorID",
                        column: x => x.ColorID,
                        principalTable: "Colours",
                        principalColumn: "ColorID");
                    table.ForeignKey(
                        name: "FK_ProductDetails_CPUs_CPUID",
                        column: x => x.CPUID,
                        principalTable: "CPUs",
                        principalColumn: "CPUID");
                    table.ForeignKey(
                        name: "FK_ProductDetails_Displays_DisplayID",
                        column: x => x.DisplayID,
                        principalTable: "Displays",
                        principalColumn: "DisplayID");
                    table.ForeignKey(
                        name: "FK_ProductDetails_GPUs_GPUID",
                        column: x => x.GPUID,
                        principalTable: "GPUs",
                        principalColumn: "GPUID");
                    table.ForeignKey(
                        name: "FK_ProductDetails_Materials_MaterialID",
                        column: x => x.MaterialID,
                        principalTable: "Materials",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDetails_OperatingSystems_OperatingSystemOSID",
                        column: x => x.OperatingSystemOSID,
                        principalTable: "OperatingSystems",
                        principalColumn: "OSID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Origins_OriginID",
                        column: x => x.OriginID,
                        principalTable: "Origins",
                        principalColumn: "OriginID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID");
                    table.ForeignKey(
                        name: "FK_ProductDetails_RAMs_RAMID",
                        column: x => x.RAMID,
                        principalTable: "RAMs",
                        principalColumn: "RAMID");
                    table.ForeignKey(
                        name: "FK_ProductDetails_RearCameras_RearCameraID",
                        column: x => x.RearCameraID,
                        principalTable: "RearCameras",
                        principalColumn: "RearCameraID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDetails_ROMs_ROMID",
                        column: x => x.ROMID,
                        principalTable: "ROMs",
                        principalColumn: "ROMID");
                    table.ForeignKey(
                        name: "FK_ProductDetails_Sales_SaleID",
                        column: x => x.SaleID,
                        principalTable: "Sales",
                        principalColumn: "SaleID");
                    table.ForeignKey(
                        name: "FK_ProductDetails_Versions_VersionID",
                        column: x => x.VersionID,
                        principalTable: "Versions",
                        principalColumn: "VersionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Vouchers_VoucherIDVoucher",
                        column: x => x.VoucherIDVoucher,
                        principalTable: "Vouchers",
                        principalColumn: "IDVoucher",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Warranties_WarrantyID",
                        column: x => x.WarrantyID,
                        principalTable: "Warranties",
                        principalColumn: "WarrantyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Weights_WeightID",
                        column: x => x.WeightID,
                        principalTable: "Weights",
                        principalColumn: "WeightID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDetails_YearsOfManufacture_YearOfManufactureYearID",
                        column: x => x.YearOfManufactureYearID,
                        principalTable: "YearsOfManufacture",
                        principalColumn: "YearID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IMEI = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_ProductDetails_IMEI",
                        column: x => x.IMEI,
                        principalTable: "ProductDetails",
                        principalColumn: "IMEI");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_Username",
                table: "Accounts",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Email",
                table: "Customers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_IMEI",
                table: "OrderDetails",
                column: "IMEI");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AccountID",
                table: "Orders",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_VoucherIDVoucher",
                table: "Orders",
                column: "VoucherIDVoucher");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_BatteryCapacityBatteryID",
                table: "ProductDetails",
                column: "BatteryCapacityBatteryID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_CameraSelfieID",
                table: "ProductDetails",
                column: "CameraSelfieID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ColorID",
                table: "ProductDetails",
                column: "ColorID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_CPUID",
                table: "ProductDetails",
                column: "CPUID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_DisplayID",
                table: "ProductDetails",
                column: "DisplayID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_GPUID",
                table: "ProductDetails",
                column: "GPUID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_MaterialID",
                table: "ProductDetails",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_OperatingSystemOSID",
                table: "ProductDetails",
                column: "OperatingSystemOSID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_OriginID",
                table: "ProductDetails",
                column: "OriginID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductID",
                table: "ProductDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_RAMID",
                table: "ProductDetails",
                column: "RAMID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_RearCameraID",
                table: "ProductDetails",
                column: "RearCameraID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ROMID",
                table: "ProductDetails",
                column: "ROMID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_SaleID",
                table: "ProductDetails",
                column: "SaleID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_VersionID",
                table: "ProductDetails",
                column: "VersionID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_VoucherIDVoucher",
                table: "ProductDetails",
                column: "VoucherIDVoucher");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_WarrantyID",
                table: "ProductDetails",
                column: "WarrantyID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_WeightID",
                table: "ProductDetails",
                column: "WeightID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_YearOfManufactureYearID",
                table: "ProductDetails",
                column: "YearOfManufactureYearID");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_ProductID",
                table: "Statistics",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "BatteryCapacities");

            migrationBuilder.DropTable(
                name: "CameraSelfies");

            migrationBuilder.DropTable(
                name: "Colours");

            migrationBuilder.DropTable(
                name: "CPUs");

            migrationBuilder.DropTable(
                name: "Displays");

            migrationBuilder.DropTable(
                name: "GPUs");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "OperatingSystems");

            migrationBuilder.DropTable(
                name: "Origins");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "RAMs");

            migrationBuilder.DropTable(
                name: "RearCameras");

            migrationBuilder.DropTable(
                name: "ROMs");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Versions");

            migrationBuilder.DropTable(
                name: "Vouchers");

            migrationBuilder.DropTable(
                name: "Warranties");

            migrationBuilder.DropTable(
                name: "Weights");

            migrationBuilder.DropTable(
                name: "YearsOfManufacture");
        }
    }
}
