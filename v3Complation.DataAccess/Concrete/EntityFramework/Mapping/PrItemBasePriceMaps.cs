using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Entities.Concrete;

namespace v3Complation.DataAccess.Concrete.EntityFramework.Mapping
{
    public class PrItemBasePriceMaps : IEntityTypeConfiguration<PrItemBasePrice>
    {
        public void Configure(EntityTypeBuilder<PrItemBasePrice> builder)
        {
            builder.ToTable("prItemBasePrices");//Tablo adini belirledik

            builder.HasKey(t => new { t.ItemTypeCode, t.ItemCode, t.BasePriceCode,t.CountryCode});//Primary keyleri belirledik

            builder.Property(t => t.ItemTypeCode)
                .HasColumnName("ItemTypeCode");

            builder.Property(t => t.ItemCode)
                .HasColumnName("ItemCode")
                .HasMaxLength(30);

            builder.Property(t => t.BasePriceCode)
                .HasColumnName("BasePriceCode");

            builder.Property(t => t.CurrencyCode)
                .HasColumnName("CurrencyCode")
                .HasMaxLength(10);

            builder.Property(t => t.CountryCode)
                .HasColumnName("CountryCode")
                .HasMaxLength(10);

            builder.Property(t => t.PriceDate)
                .HasColumnName("PriceDate")
                .IsRequired();

            builder.Property(t => t.Price)
                .HasColumnName("Price")
                .HasColumnType("money")
                .IsRequired();

            builder.Property(t => t.RowGuid)
                .HasColumnName("RowGuid")
                .IsRequired();

            //Iliskileri kuruyoruz
            builder.HasOne<BsItemType>(t => t.BsItemType)
                .WithMany(t => t.PrItemBasePrices)
                .HasForeignKey(t => t.ItemTypeCode)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<CdItem>(t => t.CdItem)
                .WithMany(t => t.PrItemBasePrices)
                .HasForeignKey(t => t.ItemCode)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<BsBasePrice>(t => t.BsBasePrice)
                .WithMany(t => t.PrItemBasePrices)
                .HasForeignKey(t => t.BasePriceCode)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<CdCurrency>(t => t.CdCurrency)
                .WithMany(t => t.PrItemBasePrices)
                .HasForeignKey(t => t.CurrencyCode)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<CdCountry>(t => t.CdCountry)
                .WithMany(t => t.PrItemBasePrices)
                .HasForeignKey(t => t.CountryCode);



        }

       
    }
}
