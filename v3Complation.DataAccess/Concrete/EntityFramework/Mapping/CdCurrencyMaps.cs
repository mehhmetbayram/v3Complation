using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Entities.Concrete;

namespace v3Complation.DataAccess.Concrete.EntityFramework.Mapping
{
    public class CdCurrencyMaps : IEntityTypeConfiguration<CdCurrency>
    {
        public void Configure(EntityTypeBuilder<CdCurrency> builder)
        {
            builder.ToTable("cdCurrencies");//Tablo adini belirledik

            builder.HasKey(t => t.CurrencyCode);//Primary key

            builder.Property(t => t.CurrencyCode)
                .HasColumnName("CurrencyCode")
                .HasMaxLength(10);

            builder.Property(t => t.CurrencyDescription)
                .HasColumnName("CurrencyDescription")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(t => t.LanguageCode)
                .HasColumnName("LanguageCode")
                .HasMaxLength(10)
                .IsRequired();

            //Iliskileri kuruyoruz
            builder.HasOne<CdLanguage>(t => t.CdLanguage)
                .WithMany(t => t.CdCurrencies)
                .HasForeignKey(t => t.LanguageCode)
                .OnDelete(DeleteBehavior.Restrict);



            //Default degerleri tanimiyoruz
            builder.HasData
                (
                new CdCurrency
                {
                    CurrencyCode = "TRY",
                    LanguageCode = "TR",
                    CurrencyDescription = "Türk Lirası",
                    RowGuid = Guid.NewGuid(),
                    IsActive = true,
                    CreateDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                }
                );

        }
    }
}
