using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Entities.Concrete;

namespace v3Complation.DataAccess.Concrete.EntityFramework.Mapping
{
    public class TrStockMaps : IEntityTypeConfiguration<TrStock>
    {
        public void Configure(EntityTypeBuilder<TrStock> builder)
        {
            builder.ToTable("trStocks");//Tablo adini belirledik

            builder.HasKey(t => new {t.ItemTypeCode,t.ItemCode,t.ColorCode,t.ItemDim1Code,t.Barcode});//Primary key leri belirkedik

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

            builder.Property(t => t.Barcode)
                .HasColumnName("Barcode")
                .HasMaxLength(30);

            builder.Property(t => t.Quantity)
                .HasColumnName("Quantity")
                .IsRequired();

            builder.Property(t => t.RowGuid)
                .HasColumnName("RowGuid")
                .IsRequired();


            //Iliskileri kuruyoruz
            builder.HasOne<BsItemType>(t => t.BsItemType)
                .WithMany(t => t.TrStocks)
                .HasForeignKey(t => t.ItemTypeCode)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<CdItem>(t => t.CdItem)
                .WithMany(t => t.TrStocks)
                .HasForeignKey(t => t.ItemCode)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<CdColor>(t => t.CdColor)
                .WithMany(t => t.TrStocks)
                .HasForeignKey(t => t.ColorCode)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<CdItemDim1>(t => t.CdItemDim1)
                .WithMany(t => t.TrStocks)
                .HasForeignKey(t => t.ItemDim1Code)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<PrItemBarcode>(t => t.PrItemBarcode)
                .WithMany(t => t.TrStocks)
                .HasForeignKey(t => t.Barcode)
                .OnDelete(DeleteBehavior.Restrict);



        }
    }
}
