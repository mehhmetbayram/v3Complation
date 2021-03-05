using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Entities.Concrete;

namespace v3Complation.DataAccess.Concrete.EntityFramework.Mapping
{
    public class CdLanguageMaps : IEntityTypeConfiguration<CdLanguage>
    {
        public void Configure(EntityTypeBuilder<CdLanguage> builder)
        {
            builder.ToTable("cdLanguages");//Tablo adini belirledik

            builder.HasKey(t => t.LanguageCode);//Primary key

            builder.Property(t => t.LanguageCode)
                .HasColumnName("LanguageCode")
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(t => t.LanguageDescription)
                .HasColumnName("LanguageDescription")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(t => t.RowGuid)
                .HasColumnName("RowGuid")
                .IsRequired();

            //Default degerleri tanimliyoruz
            builder.HasData
                (
                
                new CdLanguage
                {
                    LanguageCode = "TR",
                    LanguageDescription = "Turkce",
                    RowGuid = Guid.NewGuid()
                }
            );
        }


    }
}
