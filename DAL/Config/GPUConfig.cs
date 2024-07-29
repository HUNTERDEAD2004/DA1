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
    public class GPUConfig : IEntityTypeConfiguration<Gpu>
    {
        public void Configure(EntityTypeBuilder<Gpu> builder)
        {
            builder.HasKey(x => x.GPUID);

            builder.Property(x => x.GPUName)
                   .HasMaxLength(100);

            builder.Property(x => x.GPUMemory)
                   .HasMaxLength(20);
        }
    }
}
