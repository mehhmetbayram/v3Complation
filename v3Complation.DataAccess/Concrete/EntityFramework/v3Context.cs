using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using v3Complation.DataAccess.Concrete.EntityFramework.Mapping;
using v3Complation.Entities.Concrete;

namespace v3Complation.DataAccess.Concrete.EntityFramework
{
    public class v3Context:DbContext
    {
        public virtual DbSet<BsItemType> BsItemTypes { get; set; }
        public virtual DbSet<BsItemDimType> BsItemDimTypes { get; set; }
        public virtual DbSet<CdUnitOfMeasure> CdUnitOfMeasures { get; set; }
        public virtual DbSet<CdHierarchy> CdHierarchies { get; set; }
        public virtual DbSet<CdItemTaxGr> CdItemTaxGrs { get; set; }
        public virtual DbSet<CdColor> CdColors { get; set; }
        public virtual DbSet<CdItemDim1> CdItemDim1s { get; set; }
        public virtual DbSet<CdItem> CdItems { get; set; }
        public virtual DbSet<PrItemHierarchy> PrItemHierarchies { get; set; }
        public virtual DbSet<PrItemVariant> PrItemVariants { get; set; }
        public virtual DbSet<CdBarcodeType> CdBarcodeTypes { get; set; }
        public virtual DbSet<PrItemBarcode> PrItemBarcodes { get; set; }
        public virtual DbSet<CdLanguage> CdLanguages { get; set; }
        public virtual DbSet<BsBasePrice> BsBasePrices { get; set; }
        public virtual DbSet<CdCurrency> CdCurrencies { get; set; }
        public virtual DbSet<PrItemBasePrice> PrItemBasePrices { get; set; }
        public virtual DbSet<PrItemNote> PrItemNotes { get; set; }
        public virtual DbSet<CdCountry> CdCountries { get; set; }
        public virtual DbSet<PrItemPhoto> PrItemPhotos { get; set; }
        public virtual DbSet<TrStock> TrStocks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Class Mapping tanimlarini yapiyoruz..

            modelBuilder.ApplyConfiguration(new BsItemTypeMaps());
            modelBuilder.ApplyConfiguration(new BsItemDimTypeMaps());
            modelBuilder.ApplyConfiguration(new CdUnitOfMeasureMaps());
            modelBuilder.ApplyConfiguration(new CdHierarchyMaps());
            modelBuilder.ApplyConfiguration(new CdItemTaxGrMaps());
            modelBuilder.ApplyConfiguration(new CdColorMaps());
            modelBuilder.ApplyConfiguration(new CdItemDim1Maps());
            modelBuilder.ApplyConfiguration(new CdItemMaps());
            modelBuilder.ApplyConfiguration(new PrItemHierarchyMaps());
            modelBuilder.ApplyConfiguration(new PrItemVariantMaps());
            modelBuilder.ApplyConfiguration(new CdBarcodeTypeMaps());
            modelBuilder.ApplyConfiguration(new PrItemBarcodeMaps());
            modelBuilder.ApplyConfiguration(new CdLanguageMaps());
            modelBuilder.ApplyConfiguration(new BsBasePriceMaps());
            modelBuilder.ApplyConfiguration(new CdCurrencyMaps());
            modelBuilder.ApplyConfiguration(new PrItemBasePriceMaps());
            modelBuilder.ApplyConfiguration(new PrItemNoteMaps());
            modelBuilder.ApplyConfiguration(new CdCountryMaps());
            modelBuilder.ApplyConfiguration(new PrItemPhotoMaps());
            modelBuilder.ApplyConfiguration(new TrStockMaps());
            

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json");

                var configuration = builder.Build();

                optionsBuilder
                    //.UseLazyLoadingProxies()
                    .UseSqlServer(configuration["ConnectionStrings:v3Connection"]);
            }
        }
    }
}
