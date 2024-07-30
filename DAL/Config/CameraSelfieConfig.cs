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
    public class CameraSelfieConfig : IEntityTypeConfiguration<CameraSelfie>
    {
        public void Configure(EntityTypeBuilder<CameraSelfie> builder)
        {
            builder.HasKey(x => x.CameraSelfieID);

            builder.Property(x => x.CameraSelfieDetails)
                   .HasMaxLength(200);

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
