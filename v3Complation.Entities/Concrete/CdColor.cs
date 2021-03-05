using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Core.Entities;

namespace v3Complation.Entities.Concrete
{
    public class CdColor:BaseEntity,IEntity
    {

        //Renk tablosu


        public CdColor()
        {
            this.PrItemVariants = new HashSet<PrItemVariant>();
            this.PrItemBarcodes = new HashSet<PrItemBarcode>();
            this.PrItemPhotos = new HashSet<PrItemPhoto>();
            this.TrStocks = new HashSet<TrStock>();
        }

        public string ColorCode { get; set; }
        public string ColorDescription { get; set; }
        public int SortOrder { get; set; }

        public virtual ICollection<PrItemVariant> PrItemVariants { get; set; }
        public virtual ICollection<PrItemBarcode> PrItemBarcodes { get; set; }
        public virtual ICollection<PrItemPhoto> PrItemPhotos { get; set; }
        public virtual ICollection<TrStock> TrStocks { get; set; }
    }
}
