using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Core.Entities;

namespace v3Complation.Entities.Concrete
{
    public class TrStock:BaseEntity,IEntity
    {
        public int ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public string ColorCode { get; set; }
        public string ItemDim1Code { get; set; }
        public string Barcode { get; set; }
        public float Quantity { get; set; }
        public Guid RowGuid { get; set; }

        public virtual BsItemType BsItemType { get; set; }
        public virtual CdItem CdItem { get; set; }
        public virtual CdColor CdColor { get; set; }
        public virtual CdItemDim1 CdItemDim1 { get; set; }
        public virtual PrItemBarcode PrItemBarcode { get; set; }
    }
}
