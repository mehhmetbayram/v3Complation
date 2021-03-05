using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Entities.Concrete;

namespace v3Complation.DataAccess.Concrete.EntityFramework.Mapping
{
    public class CdItemTaxGrMaps : IEntityTypeConfiguration<CdItemTaxGr>
    {
        public void Configure(EntityTypeBuilder<CdItemTaxGr> builder)
        {
            //Kdv tablosu

            builder.ToTable("cItemTaxGrs");//Tablo adini belirttik

            builder.HasKey(t => t.ItemTaxGrCode);//Primary key 

            builder.Property(t => t.ItemTaxGrCode)
                .HasColumnName("ItemTaxGrCode")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(t => t.ItemTaxGrDescription)
                .HasColumnName("ItemTaxGrDescription")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(t => t.RowGuid)
                .HasColumnName("RowGuid");

            builder.HasData
                (
                new CdItemTaxGr
                {
                    ItemTaxGrCode="%0",
                    ItemTaxGrDescription="Vergisiz",
                    CreateDate=DateTime.Now,
                    ModifiedDate=DateTime.Now,
                    IsActive=true,
                    RowGuid=Guid.NewGuid()
                },
                new CdItemTaxGr
                {
                    ItemTaxGrCode = "%1",
                    ItemTaxGrDescription = "%1 Vergi",
                    CreateDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    RowGuid = Guid.NewGuid()
                }
                ,
                new CdItemTaxGr
                {
                    ItemTaxGrCode = "%8",
                    ItemTaxGrDescription = "%8 Vergi",
                    CreateDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    RowGuid = Guid.NewGuid()
                }
                );
        }
    }
}
