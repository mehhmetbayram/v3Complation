using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Entities.Concrete;

namespace v3Complation.DataAccess.Concrete.EntityFramework.Mapping
{
    public class PrItemNoteMaps : IEntityTypeConfiguration<PrItemNote>
    {
        public void Configure(EntityTypeBuilder<PrItemNote> builder)
        {
            builder.ToTable("prItemNotes");//Tablo adini belirledik

            builder.HasKey(t => t.ItemCode);//Primary key

            builder.Property(t => t.ItemCode)
                .HasColumnName("ItemCode")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("ntext")
                .IsRequired(false);

            builder.Property(t => t.RowGuid)
                .HasColumnName("RowGuid")
                .IsRequired();

        
        }
    }
}
