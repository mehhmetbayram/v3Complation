using System;
using System.Collections.Generic;
using System.Text;

namespace v3Complation.Entities.Concrete
{
    public class BaseEntity
    {
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }

    }
}
