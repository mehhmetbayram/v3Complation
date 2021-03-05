using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Entities.Concrete;

namespace v3Complation.DataAccess.Concrete.EntityFramework.Mapping
{
    public class PrItemVariantMaps : IEntityTypeConfiguration<PrItemVariant>
    {
        public void Configure(EntityTypeBuilder<PrItemVariant> builder)
        {
            builder.ToTable("prItemVariants");//Tablo adini belirledik


            builder.HasKey(t => new { t.ItemTypeCode, t.ItemCode, t.ColorCode, t.ItemDim1Code });

            builder.Property(t => t.ItemTypeCode)
                .HasColumnName("ItemTypeCode");

            builder.Property(t => t.ItemCode)
                .HasColumnName("ItemCode")
                .HasMaxLength(30);

            builder.Property(t => t.ColorCode)
                .HasColumnName("ColorCode")
                .HasMaxLength(10);

            builder.Property(t => t.ItemDim1Code)
                .HasColumnName("ItemDim1Code")
                .HasMaxLength(10);

            builder.Property(t => t.RowGuid)
                .HasColumnName("RowGuid");

            //Iliskileri kuruyoruz

            builder.HasOne<BsItemType>(t => t.BsItemType)
                .WithMany(t => t.PrItemVariants)
                .HasForeignKey(t => t.ItemTypeCode);

            builder.HasOne<CdItem>(t => t.CdItem)
                .WithMany(t => t.PrItemVariants)
                .HasForeignKey(t => t.ItemCode);

            builder.HasOne<CdColor>(t => t.CdColor)
                .WithMany(t => t.PrItemVariants)
                .HasForeignKey(t => t.ColorCode);

            builder.HasOne<CdItemDim1>(t => t.CdItemDim1)
                .WithMany(t => t.PrItemVariants)
                .HasForeignKey(t => t.ItemDim1Code);
        }
    }
}
