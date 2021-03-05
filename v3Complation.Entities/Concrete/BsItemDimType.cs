using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Core.Entities;

namespace v3Complation.Entities.Concrete
{
    public class BsItemDimType:IEntity
    {
        //Urun boyut tablosu => urunun varyantsiz mi ? sadece renkmi ? hem renk hem numara mi ? olacagini belirleyecigimiz class

        public int ItemDimTypeCode { get; set; }

        public string ItemDimTypeDescription { get; set; }

        public Guid RowGuid { get; set; }

        public virtual ICollection<CdItem> CdItems { get; set; }
    }
}
