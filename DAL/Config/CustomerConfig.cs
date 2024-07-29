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
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.CustomerID);

            builder.Property(x => x.CustomerName)
                   .IsRequired()
                   .HasMaxLength(255);

            builder.Property(x => x.Email)
                   .HasMaxLength(255);

            builder.Property(x => x.PhoneNumber)
                   .HasMaxLength(20);

            builder.Property(x => x.Address)
                   .HasMaxLength(500);

            builder.Property(x => x.Point)
                   .IsRequired();

            builder.Property(x => x.Age)
                   .HasMaxLength(20);

            builder.Property(x => x.Gender)
                   .HasMaxLength(20);

            builder.HasIndex(x => x.Email)
                   .IsUnique();
        }
    }
}
