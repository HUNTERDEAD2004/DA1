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
    public class StatisticConfig : IEntityTypeConfiguration<Statistics>
    {
        public void Configure(EntityTypeBuilder<Statistics> builder)
        {
            builder.HasKey(x => x.StatisticID);

            builder.Property(x => x.ReportDate)
                   .IsRequired();

            builder.Property(x => x.ProductName)
                   .HasMaxLength(255);

            builder.HasOne(x => x.Product)
                   .WithMany(p => p.Statistics)
                   .HasForeignKey(x => x.ProductID);
        }
    }
}
