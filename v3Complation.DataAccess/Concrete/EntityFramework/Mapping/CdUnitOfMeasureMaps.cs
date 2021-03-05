using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Entities.Concrete;

namespace v3Complation.DataAccess.Concrete.EntityFramework.Mapping
{
    public class CdUnitOfMeasureMaps : IEntityTypeConfiguration<CdUnitOfMeasure>
    {
        public void Configure(EntityTypeBuilder<CdUnitOfMeasure> builder)
        {
            builder.ToTable("cdUnitOfMeasures");//Tablo adini belirttik

            builder.HasKey(t => t.UnitOfMeasureCode);//Primary key

            builder.Property(t => t.UnitOfMeasureCode)
                .HasColumnName("UnitOfMeasureCode")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(t => t.UnitOfMeasureDescription)
                .HasColumnName("UnitOfMeasureDescription")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(t => t.RowGuid)
                .HasColumnName("RowGuid");


            //Default degerleri tanimliyoruz..Tablo create edilince insert edilecek data

            builder.HasData
                (
                new CdUnitOfMeasure
                {
                    UnitOfMeasureCode = "AD",
                    UnitOfMeasureDescription = "Adet",
                    CreateDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    RowGuid = Guid.NewGuid()
                }, new CdUnitOfMeasure
                {
                    UnitOfMeasureCode = "KG",
                    UnitOfMeasureDescription = "Kilo",
                    CreateDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    RowGuid = Guid.NewGuid()
                }, new CdUnitOfMeasure
                {
                    UnitOfMeasureCode = "GR",
                    UnitOfMeasureDescription = "Gram",
                    CreateDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    RowGuid = Guid.NewGuid(),
                }, new CdUnitOfMeasure
                {
                    UnitOfMeasureCode = "L",
                    UnitOfMeasureDescription = "Litre",
                    CreateDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    RowGuid = Guid.NewGuid(),
                }
                );

        }
    }
}
