using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Core.Entities;

namespace v3Complation.Entities.Concrete
{
    public class PrItemNote:BaseEntity,IEntity
    {
        //Madde not ve aciklama tablosu
        public string ItemCode { get; set; }

        public string Description { get; set; }
        public Guid RowGuid { get; set; }

        public virtual CdItem CdItem { get; set; }
    }
}
