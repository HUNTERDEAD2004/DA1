using AppData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Config
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.OrderID);

            builder.Property(x => x.TotalAmount)
                   .HasColumnType("decimal(18, 2)");

            builder.Property(x => x.Price)
                   .HasColumnType("decimal(18, 2)");

            builder.HasOne(x => x.Customer)
                   .WithMany()
                   .HasForeignKey(x => x.CustomerID);

            builder.HasOne(x => x.Account)
                   .WithMany()
                   .HasForeignKey(x => x.AccountID);

            builder.HasOne(x => x.Voucher)
                   .WithMany(s => s.Orders)
                   .HasForeignKey(x => x.IDVoucher)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
