using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Entities.Concrete;

namespace v3Complation.DataAccess.Concrete.EntityFramework.Mapping
{
    public class BsItemDimTypeMaps : IEntityTypeConfiguration<BsItemDimType>
    {
        public void Configure(EntityTypeBuilder<BsItemDimType> builder)
        {
            builder.ToTable("bsItemDimTypes");//Tablo adini belirttik

            builder.HasKey(t => t.ItemDimTypeCode);//Primary key

            builder.Property(t => t.ItemDimTypeCode)
                .HasColumnName("ItemDimTypeCode");

            builder.Property(t => t.ItemDimTypeDescription)
                .HasColumnName("ItemDimTypeDescription")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(t => t.RowGuid)
                .HasColumnName("RowGuid");

         

            builder.HasData
                (
                new BsItemDimType
                {
                    ItemDimTypeCode=1,
                    ItemDimTypeDescription="Varyantsiz",
                    RowGuid=Guid.NewGuid()
                },
                new BsItemDimType
                {
                    ItemDimTypeCode=2,
                    ItemDimTypeDescription="Renk",
                    RowGuid=Guid.NewGuid()
                },
                new BsItemDimType
                {
                    ItemDimTypeCode=3,
                    ItemDimTypeDescription="RenkBeden",
                    RowGuid=Guid.NewGuid()
                }
                );
        }
    }
}
