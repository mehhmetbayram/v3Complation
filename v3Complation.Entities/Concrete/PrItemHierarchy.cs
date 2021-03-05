using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Core.Entities;

namespace v3Complation.Entities.Concrete
{
    public class PrItemHierarchy:IEntity
    {
        public int HierarchyCode { get; set; }

        public string ItemCode { get; set; }

        public virtual CdHierarchy CdHierarchy { get; set; }

        public virtual CdItem CdItem { get; set; }
    }
}
