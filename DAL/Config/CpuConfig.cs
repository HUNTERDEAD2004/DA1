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
    public class CpuConfig : IEntityTypeConfiguration<Cpu>
    {
        public void Configure(EntityTypeBuilder<Cpu> builder)
        {
            builder.HasKey(x => x.CPUID);

            builder.Property(x => x.CPUName)
                   .HasMaxLength(100);

            builder.Property(x => x.CPUClockSpeed)
                   .HasMaxLength(20);
        }
    }
}
