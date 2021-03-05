using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Entities.Concrete;

namespace v3Complation.DataAccess.Concrete.EntityFramework.Mapping
{
    public class CdItemDim1Maps : IEntityTypeConfiguration<CdItemDim1>
    {
        public void Configure(EntityTypeBuilder<CdItemDim1> builder)
        {
            //Beden tablosu

            builder.ToTable("cdItemDim1s");//Tablo adini belirttik

            builder.HasKey(t => t.ItemDim1Code);//Primary key

            builder.Property(t => t.ItemDim1Code)
                .HasColumnName("ItemDim1Code")
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(t => t.ItemDim1Description)
                .HasColumnName("ItemDim1Description")
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(t => t.SortOrder)
                .HasColumnName("SortOrder")
                .HasMaxLength(444);
        }
    }
}
