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
    public class RomConfig : IEntityTypeConfiguration<Rom>
    {
        public void Configure(EntityTypeBuilder<Rom> builder)
        {
            builder.HasKey(x => x.ROMID);

            builder.Property(x => x.ROMSize)
                   .HasMaxLength(20);
        }
    }
}
