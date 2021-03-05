using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Core.Entities;

namespace v3Complation.Entities.Concrete
{
    public class CdItemDim1:BaseEntity,IEntity
    {
        //Beden tablosu

        public CdItemDim1()
        {
            this.PrItemVariants = new HashSet<PrItemVariant>();
            this.PrItemBarcodes = new HashSet<PrItemBarcode>();
            this.TrStocks = new HashSet<TrStock>();
        }
        public string ItemDim1Code { get; set; }

        public string ItemDim1Description { get; set; }

        public int SortOrder { get; set; }

        public virtual ICollection<PrItemVariant> PrItemVariants { get; set; }
        public virtual ICollection<PrItemBarcode> PrItemBarcodes { get; set; }
        public virtual ICollection<TrStock> TrStocks { get; set; }
    }
}
