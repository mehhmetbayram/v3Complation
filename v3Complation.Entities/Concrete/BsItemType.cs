using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Core.Entities;

namespace v3Complation.Entities.Concrete
{
    public class BsItemType:IEntity
    {

        /*
         * 
         * Madde tip tablosu 
         * Madde urun mu olacak - masraf mi olacak
         * Varsayilan degerler class'in mapping bolumunde tanimlanacak
         * 
        */
        public BsItemType()
        {
            this.CdItems = new HashSet<CdItem>();
            this.PrItemVariants = new HashSet<PrItemVariant>();
            this.PrItemBarcodes = new HashSet<PrItemBarcode>();
            this.PrItemBasePrices = new HashSet<PrItemBasePrice>();
            this.PrItemPhotos = new HashSet<PrItemPhoto>();
            this.TrStocks = new HashSet<TrStock>();
        }

        public int ItemTypeCode { get; set; }
        public string ItemTypeDescription { get; set; }
        public Guid RowGuid{ get; set; }

        public virtual ICollection<CdItem> CdItems { get; set; }
        public virtual ICollection<PrItemVariant> PrItemVariants { get; set; }
        public virtual ICollection<PrItemBarcode> PrItemBarcodes { get; set; }
        public virtual ICollection<PrItemBasePrice> PrItemBasePrices { get; set; }
        public virtual ICollection<PrItemPhoto> PrItemPhotos { get; set; }
        public virtual ICollection<TrStock> TrStocks { get; set; }
    }
}
