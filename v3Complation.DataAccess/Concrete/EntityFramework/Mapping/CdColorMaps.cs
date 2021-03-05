using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Entities.Concrete;

namespace v3Complation.DataAccess.Concrete.EntityFramework.Mapping
{
    public class CdColorMaps : IEntityTypeConfiguration<CdColor>
    {
        public void Configure(EntityTypeBuilder<CdColor> builder)
        {
            builder.ToTable("cdColors");//Tablo adini belirttik

            builder.HasKey(t => t.ColorCode);//Primary key

            builder.Property(t => t.ColorCode)
                .HasColumnName("ColorCode")
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(t => t.ColorDescription)
                .HasColumnName("ColorDescription")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(t => t.SortOrder)
                .HasColumnName("SortOrder")
                .IsRequired();
        }
    }
}
