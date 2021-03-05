using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Entities.Concrete;

namespace v3Complation.DataAccess.Concrete.EntityFramework.Mapping
{
    public class CdHierarchyMaps : IEntityTypeConfiguration<CdHierarchy>
    {
        public void Configure(EntityTypeBuilder<CdHierarchy> builder)
        {
            builder.ToTable("cdHierarchies");//Tablo adini belirledik

            builder.HasKey(t => t.HierarchyCode);//Primary key

            builder.Property(t => t.HierarchyCode)
                .HasColumnName("HierarchyCode");

            builder.Property(t => t.ParentHierarchyCode)
                .HasColumnName("ParentHierarchyCode")
                .HasDefaultValueSql("0")
                .IsRequired(false);

            builder.Property(t => t.HierarchyDescription)
                .HasColumnName("HierarchyDescription")
                .HasMaxLength(150)
                .IsRequired();

            

        }
    }
}
