using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Core.Entities;

namespace v3Complation.Entities.Concrete
{
    public class CdUnitOfMeasure:BaseEntity,IEntity
    {

        //Birim cinsi tablosu urunun birim cinsini belirdegimiz tablo kg.metre,gram,adet vb.

        public CdUnitOfMeasure()
        {
            this.CdItems = new HashSet<CdItem>();
            this.PrItemBarcodes = new HashSet<PrItemBarcode>();
        }

        public string UnitOfMeasureCode { get; set; }

        public string UnitOfMeasureDescription { get; set; }

        public Guid RowGuid { get; set; }

        public virtual ICollection<CdItem> CdItems { get; set; }
        public virtual ICollection<PrItemBarcode> PrItemBarcodes { get; set; }
    }
}
