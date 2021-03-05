using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Core.Entities;

namespace v3Complation.Entities.Concrete
{
    public class CdBarcodeType:IEntity
    {
        public CdBarcodeType()
        {
            this.PrItemBarcodes = new HashSet<PrItemBarcode>();
        }

        //Barkod tip tablosu

        public string BarcodeTypeCode { get; set; }
        public string BarcodeTypeDescription { get; set; }

        public virtual ICollection<PrItemBarcode> PrItemBarcodes { get; set; }

    }
}
