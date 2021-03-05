using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Entities.Concrete;

namespace v3Complation.DataAccess.Concrete.EntityFramework.Mapping
{
    public class PrItemHierarchyMaps : IEntityTypeConfiguration<PrItemHierarchy>
    {
        public void Configure(EntityTypeBuilder<PrItemHierarchy> builder)
        {
            builder.ToTable("prItemHierarchies");//Tablo adini belirledik

            builder.HasKey(t => new { t.ItemCode, t.HierarchyCode });

            builder.Property(t => t.ItemCode)
                .HasColumnName("ItemCode");

            builder.Property(t => t.HierarchyCode)
                .HasColumnName("HierarchyCode");

            builder.HasOne<CdItem>(t => t.CdItem)
                .WithMany(t => t.PrItemHierarchies)
                .HasForeignKey(t => t.ItemCode);

            builder.HasOne<CdHierarchy>(t => t.CdHierarchy)
                .WithMany(t => t.PrItemHierarchies)
                .HasForeignKey(t => t.HierarchyCode);
        }
    }
}
