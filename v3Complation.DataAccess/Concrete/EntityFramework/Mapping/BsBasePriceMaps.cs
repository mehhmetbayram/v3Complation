using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Entities.Concrete;

namespace v3Complation.DataAccess.Concrete.EntityFramework.Mapping
{
    public class BsBasePriceMaps : IEntityTypeConfiguration<BsBasePrice>
    {
        public void Configure(EntityTypeBuilder<BsBasePrice> builder)
        {
            builder.ToTable("bsBasePrices");//Tablo adini belirledik

            builder.HasKey(t => t.BasePriceCode);//Primary key

            builder.Property(t => t.BasePriceCode)
                .HasColumnName("BasePriceCode");

            builder.Property(t => t.BasePriceDescription)
                .HasColumnName("BasePriceDescription")
                .HasMaxLength(70)
                .IsRequired();

            builder.Property(t => t.RowGuid)
                .HasColumnName("RowGuid")
                .IsRequired();

            builder.Property(t => t.LanguageCode)
                .HasColumnName("LanguageCode")
                .HasMaxLength(10)
                .IsRequired();

            //Iliskileri kuruyoruz
            builder.HasOne<CdLanguage>(t => t.CdLanguage)
                .WithMany(t => t.BsBasePrices)
                .HasForeignKey(t => t.LanguageCode)
                .OnDelete(DeleteBehavior.Restrict);

            //Default degerleri atiyoruz
            //builder.HasData
            //    (
            //    new BsBasePrice
            //    {
            //        BasePriceDescription = "Maliyet Fiyatı",
            //        LanguageCode = "TR",
            //        RowGuid = Guid.NewGuid()

            //    }, new BsBasePrice
            //    {
            //        BasePriceDescription = "Satın Alma Fiyatı (VH)",
            //        LanguageCode = "TR",
            //        RowGuid = Guid.NewGuid()

            //    }, new BsBasePrice
            //    {
            //        BasePriceDescription = "Toptan Satış Fiyatı (VH)",
            //        LanguageCode = "TR",
            //        RowGuid = Guid.NewGuid()

            //    }, new BsBasePrice
            //    {
            //        BasePriceDescription = "İlk Satış Fiyatı",
            //        LanguageCode = "TR",
            //        RowGuid = Guid.NewGuid()

            //    }, new BsBasePrice
            //    {
            //        BasePriceDescription = "Hedef Satış Fiyatı",
            //        LanguageCode = "TR",
            //        RowGuid = Guid.NewGuid()

            //    }, new BsBasePrice
            //    {
            //        BasePriceDescription = "Perakende Satış Fiyatı (VD)",
            //        LanguageCode = "TR",
            //        RowGuid = Guid.NewGuid()

            //    }, new BsBasePrice
            //    {
            //        BasePriceDescription = "Perakende Taksitli Satış Fiyatı (VD)",
            //        LanguageCode = "TR",
            //        RowGuid = Guid.NewGuid()

            //    }
            //);

        }
    }
}
