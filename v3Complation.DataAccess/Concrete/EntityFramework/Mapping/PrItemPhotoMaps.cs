using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Entities.Concrete;

namespace v3Complation.DataAccess.Concrete.EntityFramework.Mapping
{
    public class PrItemPhotoMaps : IEntityTypeConfiguration<PrItemPhoto>
    {
        public void Configure(EntityTypeBuilder<PrItemPhoto> builder)
        {
            builder.ToTable("prItemPhotos");//Tablo adini belirledik

            builder.HasKey(t => new { t.ItemTypeCode, t.ItemCode, t.ColorCode });

            builder.Property(t => t.ItemTypeCode)
                .HasColumnName("ItemTypeCode");

            builder.Property(t => t.ItemCode)
                .HasColumnName("ItemCode")
                .HasMaxLength(30);

            builder.Property(t => t.ColorCode)
                .HasColumnName("ColorCode")
                .HasMaxLength(10);

            builder.Property(t => t.ImagePath)
                .HasColumnName("ImagePath")
                .HasMaxLength(300)
                .IsRequired();

            builder.Property(t => t.RowGuid)
                .HasColumnName("RowGuid")
                .IsRequired();

            builder.HasOne<BsItemType>(t => t.BsItemType)
                .WithMany(t => t.PrItemPhotos)
                .HasForeignKey(t => t.ItemTypeCode)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<CdItem>(t => t.CdItem)
                .WithMany(t => t.PrItemPhotos)
                .HasForeignKey(t => t.ItemCode)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<CdColor>(t => t.CdColor)
                .WithMany(t => t.PrItemPhotos)
                .HasForeignKey(t => t.ColorCode)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
