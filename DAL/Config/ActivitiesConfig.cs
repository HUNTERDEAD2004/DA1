using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Config
{
    public class ActivitiesConfig : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            // Định nghĩa khóa chính
            builder.HasKey(a => a.ID);

            // Định nghĩa thuộc tính Note với kiểu dữ liệu nvarchar(MAX)
            builder.Property(a => a.Note)
                   .HasColumnType("nvarchar(MAX)")
                   .IsRequired(false);

            // Định nghĩa thuộc tính CreatedAt
            builder.Property(a => a.CreatedAt)
                   .IsRequired();

            // Định nghĩa thuộc tính UpdatedAt
            builder.Property(a => a.UpdatedAt)
                   .IsRequired();

            // Định nghĩa thuộc tính CreatedBy với độ dài 50 ký tự
            builder.Property(a => a.CreatedBy)
                   .HasColumnType("nvarchar(50)")
                   .IsRequired(false);

            // Định nghĩa thuộc tính UpdatedBy với độ dài 50 ký tự
            builder.Property(a => a.UpdatedBy)
                   .HasColumnType("nvarchar(50)")
                   .IsRequired(false);
        }
    }
}
