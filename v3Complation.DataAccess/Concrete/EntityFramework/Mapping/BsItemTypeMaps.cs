using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Entities.Concrete;

namespace v3Complation.DataAccess.Concrete.EntityFramework.Mapping
{
    public class BsItemTypeMaps : IEntityTypeConfiguration<BsItemType>
    {
        public void Configure(EntityTypeBuilder<BsItemType> builder)
        {
            builder.ToTable("bsItemTypes");//Tablo adini belirledik

            builder.HasKey(t => t.ItemTypeCode);//Primary key

            builder.Property(t => t.ItemTypeCode)
                .HasColumnName("ItemTypeCode");

            builder.Property(t => t.ItemTypeDescription)
                .HasColumnName("ItemTypeDescription")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(t => t.RowGuid)
                .HasColumnName("RowGuid")
                .IsRequired();


            //Tabloya default degerleri tanimliyoruz

            builder.HasData
                (
                new BsItemType
                {
                    ItemTypeCode = 1,
                    ItemTypeDescription = "Urun",
                    RowGuid = Guid.NewGuid()
                }, new BsItemType
                {
                    ItemTypeCode = 2,
                    ItemTypeDescription = "Malzeme",
                    RowGuid = Guid.NewGuid()
                },
                new BsItemType
                {
                    ItemTypeCode=4,
                    ItemTypeDescription="Masraf", 
                    RowGuid = Guid.NewGuid()
                },
                new BsItemType
                {
                    ItemTypeCode = 5,
                    ItemTypeDescription = "Servis", 
                    RowGuid = Guid.NewGuid()
                },
                new BsItemType
                {
                    ItemTypeCode = 6,
                    ItemTypeDescription = "Sabit Kiymet", //Servis
                    RowGuid = Guid.NewGuid()
                }

                );



        }
    }
}
