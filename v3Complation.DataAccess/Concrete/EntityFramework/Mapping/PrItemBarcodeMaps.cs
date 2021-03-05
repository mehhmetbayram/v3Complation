using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Entities.Concrete;

namespace v3Complation.DataAccess.Concrete.EntityFramework.Mapping
{
    public class PrItemBarcodeMaps : IEntityTypeConfiguration<PrItemBarcode>
    {
        public void Configure(EntityTypeBuilder<PrItemBarcode> builder)
        {
            builder.ToTable("prItemBarcodes");//Tablo adini belirledik

            builder.HasKey(t => t.Barcode);//Primary key

            builder.Property(t => t.Barcode)
                .HasColumnName("Barcode")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(t => t.BarcodeTypeCode)
                .HasColumnName("BarcodeTypeCode")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(t => t.ItemTypeCode)
                .HasColumnName("ItemTypeCode")
                .IsRequired();

            builder.Property(t => t.ItemCode)
                .HasColumnName("ItemCode")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(t => t.ColorCode)
                .HasColumnName("ColorCode")
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(t => t.ItemDim1Code)
                .HasColumnName("ItemDim1Code")
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(t => t.UnitOfMeasureCode)
                .HasColumnName("UnitOfMeasureCode")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(t => t.Quantity)
                .HasColumnName("Quantity")
                .IsRequired();

            builder.Property(t => t.RowGuid)
                .HasColumnName("RowGuid")
                .IsRequired();


            //Iliskileri kuruyoruz

            builder.HasOne<CdBarcodeType>(t => t.CdBarcodeType)
                .WithMany(t => t.PrItemBarcodes)
                .HasForeignKey(t => t.BarcodeTypeCode)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<BsItemType>(t => t.BsItemType)
                .WithMany(t => t.PrItemBarcodes)
                .HasForeignKey(t => t.ItemTypeCode)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<CdItem>(t => t.CdItem)
                .WithMany(t => t.PrItemBarcodes)
                .HasForeignKey(t => t.ItemCode)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<CdColor>(t => t.CdColor)
                .WithMany(t => t.PrItemBarcodes)
                .HasForeignKey(t => t.ColorCode)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<CdItemDim1>(t => t.CdItemDim1)
                .WithMany(t => t.PrItemBarcodes)
                .HasForeignKey(t => t.ItemDim1Code)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<CdUnitOfMeasure>(t => t.CdUnitOfMeasure)
                .WithMany(t => t.PrItemBarcodes)
                .HasForeignKey(t => t.UnitOfMeasureCode)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
