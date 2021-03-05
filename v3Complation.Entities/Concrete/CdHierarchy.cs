using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Core.Entities;

namespace v3Complation.Entities.Concrete
{
    public class CdHierarchy:BaseEntity,IEntity
    {

        //Urun kategori tablosu
        public CdHierarchy()
        {
            this.PrItemHierarchies = new HashSet<PrItemHierarchy>();
        }

        public int HierarchyCode { get; set; }

        public int? ParentHierarchyCode { get; set; }  //HierarchyCode 0 olan üst kategori olacak

        public string HierarchyDescription { get; set; }

        public virtual ICollection<PrItemHierarchy> PrItemHierarchies { get; set; }
    }
}
