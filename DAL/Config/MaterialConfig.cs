using DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Config
{
    public class MaterialConfig : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> builder)
        {
            builder.HasKey(x => x.MaterialID);

            builder.Property(x => x.MaterialName)
                   .HasMaxLength(50);

            builder.Property(x => x.CreatedAt)
                   .IsRequired();

            builder.Property(x => x.UpdatedAt)
                   .IsRequired();

            builder.Property(x => x.CreatedBy)
                   .HasMaxLength(50);

            builder.Property(x => x.UpdatedBy)
                   .HasMaxLength(50);
        }
    }
}
