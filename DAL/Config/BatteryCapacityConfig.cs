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
    public class BatteryCapacityConfig : IEntityTypeConfiguration<BatteryCapacity>
    {
        public void Configure(EntityTypeBuilder<BatteryCapacity> builder)
        {
            builder.HasKey(x => x.BatteryID);
        }
    }
}
