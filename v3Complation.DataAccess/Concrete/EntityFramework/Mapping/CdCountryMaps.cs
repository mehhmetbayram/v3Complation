using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Entities.Concrete;

namespace v3Complation.DataAccess.Concrete.EntityFramework.Mapping
{
    public class CdCountryMaps : IEntityTypeConfiguration<CdCountry>
    {
        public void Configure(EntityTypeBuilder<CdCountry> builder)
        {
            builder.ToTable("cdCountries");//Tablo adini belirledik

            builder.HasKey(t => t.CountryCode);//Primary key

            builder.Property(t => t.CountryCode)
                .HasColumnName("CountryCode")
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(t => t.CountryDescription)
                .HasColumnName("CountryDescription")
                .HasMaxLength(140)
                .IsRequired();

            builder.Property(t => t.CurrencyCode)
                .HasColumnName("CurrencyCode")
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(t => t.LanguageCode)
                .HasColumnName("LanguageCode")
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(t => t.RowGuid)
                .HasColumnName("RowGuid")
                .IsRequired();

            //Iliskileri kuruyoruz
            builder.HasOne<CdCurrency>(t => t.CdCurrency)
                .WithMany(t => t.CdCountries)
                .HasForeignKey(t => t.CurrencyCode)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<CdLanguage>(t => t.CdLanguage)
                .WithMany(t => t.CdCountries)
                .HasForeignKey(t => t.LanguageCode)
                .OnDelete(DeleteBehavior.Restrict);

            //Default deger giriyoruz

            builder.HasData(new CdCountry
            {
                CountryCode="TR",
                CurrencyCode= "TRY",
                LanguageCode="TR",
                RowGuid=Guid.NewGuid(),
                CountryDescription="Turkiye",
                IsActive=true,
                CreateDate=DateTime.Now,
                ModifiedDate=DateTime.Now

            });

        }
    }
}
