using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Core.Entities;

namespace v3Complation.Entities.Concrete
{
    public class PrItemBarcode : BaseEntity, IEntity
    {

        public PrItemBarcode()
        {
            this.TrStocks = new HashSet<TrStock>();
        }

        public string Barcode { get; set; }//Primary key

        public string BarcodeTypeCode { get; set; }//Foreign key
        public virtual CdBarcodeType CdBarcodeType { get; set; }


        public int ItemTypeCode { get; set; }//Foreign key
        public virtual BsItemType BsItemType { get; set; }

        public string ItemCode { get; set; }//Foreign key
        public virtual CdItem CdItem { get; set; }

        public string ColorCode { get; set; }//Foreign key
        public virtual CdColor CdColor { get; set; }

        public string ItemDim1Code { get; set; }//Foreign key
        public virtual CdItemDim1 CdItemDim1 { get; set; }

        public string UnitOfMeasureCode { get; set; }//Foreign key
        public virtual CdUnitOfMeasure CdUnitOfMeasure { get; set; }//Birim cinsi

        public float Quantity { get; set; }

        public Guid RowGuid { get; set; }

        public virtual ICollection<TrStock> TrStocks { get; set; }




    }
}
