using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Entities.Concrete;

namespace v3Complation.DataAccess.Concrete.EntityFramework.Mapping
{
    public class CdItemMaps : IEntityTypeConfiguration<CdItem>
    {
        public void Configure(EntityTypeBuilder<CdItem> builder)
        {
            //
            builder.ToTable("cdItems");//Tablo adini belirledik

            builder.HasKey(t =>t.ItemCode);//Primary key

            builder.Property(t => t.ItemTypeCode)
                .HasColumnName("ItemTypeCode");

            builder.Property(t => t.ItemCode)
                .HasColumnName("ItemCode")
                .HasMaxLength(30);

            builder.Property(t => t.ItemDescription)
                .HasColumnName("ItemDescription")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(t => t.ByWeight)
                .HasColumnName("ByWeight");

            builder.Property(t => t.ItemDimTypeCode)
                .HasColumnName("ItemDimTypeCode");

            builder.Property(t => t.UnitOfMeasureCode)
                .HasColumnName("UnitOfMeasureCode")
                .HasMaxLength(30);


            builder.Property(t => t.ItemTaxGrCode)
                .HasColumnName("ItemTaxGrCode")
                .HasMaxLength(30);


            ///iliskileri kuruyoruz

            builder.HasOne<BsItemType>(t => t.BsItemType)
                .WithMany(t => t.CdItems)
                .HasForeignKey(t => t.ItemTypeCode)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<BsItemDimType>(t => t.BsItemDimType)
                .WithMany(t => t.CdItems)
                .HasForeignKey(t => t.ItemDimTypeCode)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<CdUnitOfMeasure>(t => t.CdUnitOfMeasure)
                .WithMany(t => t.CdItems)
                .HasForeignKey(t => t.UnitOfMeasureCode)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<CdItemTaxGr>(t => t.CdItemTaxGr)
                .WithMany(t => t.CdItems)
                .HasForeignKey(t => t.ItemTaxGrCode);


            //prItemNote tablosu ile 1e1 iliski kuruyoruz
            builder.HasOne<PrItemNote>(t => t.PrItemNote)
                .WithOne(t => t.CdItem)
                .HasForeignKey<PrItemNote>(t => t.ItemCode);


        }
    }
}
