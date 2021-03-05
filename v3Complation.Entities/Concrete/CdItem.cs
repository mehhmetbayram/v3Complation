using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Core.Entities;

namespace v3Complation.Entities.Concrete
{
    public class CdItem:BaseEntity,IEntity
    {
        public CdItem()
        {
            this.PrItemHierarchies = new HashSet<PrItemHierarchy>();
            this.PrItemVariants = new HashSet<PrItemVariant>();
            this.PrItemBarcodes = new HashSet<PrItemBarcode>();
            this.PrItemBasePrices = new HashSet<PrItemBasePrice>();
            this.PrItemPhotos = new HashSet<PrItemPhoto>();
            this.TrStocks = new HashSet<TrStock>();
        }
        public int ItemTypeCode { get; set; }//Madde tip
        public virtual BsItemType BsItemType { get; set; }//
        public string ItemCode { get; set; }//Primary key
        public string ItemDescription { get; set; }
        public short? ByWeight { get; set; }
        public bool IsDeleted { get; set; }
        public bool UseHome { get; set; }

 
        public int ItemDimTypeCode { get; set; }
        public virtual BsItemDimType BsItemDimType { get; set; }


     
        public string UnitOfMeasureCode { get; set; }

        public virtual CdUnitOfMeasure CdUnitOfMeasure { get; set; }

      

         public string ItemTaxGrCode { get; set; }

        public virtual CdItemTaxGr CdItemTaxGr { get; set; }

        public virtual PrItemNote PrItemNote { get; set; }//1e1 iliski kurulacak


        public virtual ICollection<PrItemHierarchy> PrItemHierarchies { get; set; }
        public virtual ICollection<PrItemVariant> PrItemVariants { get; set; }
        public virtual ICollection<PrItemBarcode> PrItemBarcodes { get; set; }
        public virtual ICollection<PrItemBasePrice> PrItemBasePrices { get; set; }
        public virtual ICollection<PrItemPhoto> PrItemPhotos { get; set; }
        public virtual ICollection<TrStock> TrStocks { get; set; }



    }
}
