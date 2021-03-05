using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Core.Entities;

namespace v3Complation.Entities.Concrete
{
    public class CdItemTaxGr:BaseEntity,IEntity
    {
        //Kdv tablosu

        public CdItemTaxGr()
        {
            this.CdItems = new HashSet<CdItem>();
        }
        public string ItemTaxGrCode { get; set; }

        public string ItemTaxGrDescription { get; set; }

        public Guid RowGuid { get; set; }


        public virtual ICollection<CdItem> CdItems { get; set; }
    }
}
