using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Entities.Concrete;

namespace v3Complation.DataAccess.Concrete.EntityFramework.Mapping
{
    public class CdBarcodeTypeMaps : IEntityTypeConfiguration<CdBarcodeType>
    {
        public void Configure(EntityTypeBuilder<CdBarcodeType> builder)
        {
            builder.ToTable("cdBarcodeTypes");//Tablo adini belirledik

            builder.HasKey(t => t.BarcodeTypeCode);//Primary key

            builder.Property(t => t.BarcodeTypeCode)
                .HasColumnName("BarcodeTypeCode")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(t => t.BarcodeTypeDescription)
                .HasColumnName("BarcodeTypeDescription")
                .HasMaxLength(50);


        }
    }
}
