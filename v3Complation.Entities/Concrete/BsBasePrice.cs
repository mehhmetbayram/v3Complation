using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Core.Entities;

namespace v3Complation.Entities.Concrete
{
    public class BsBasePrice:IEntity
    {

        //Fiyat tip tablosu
        //default degerler atanacak

        public BsBasePrice()
        {
            this.PrItemBasePrices = new HashSet<PrItemBasePrice>();
        }
        public int BasePriceCode { get; set; }
        public string BasePriceDescription { get; set; }
        public Guid RowGuid { get; set; }

        public string LanguageCode { get; set; }
        public virtual CdLanguage CdLanguage { get; set; }

        public virtual ICollection<PrItemBasePrice> PrItemBasePrices { get; set; }
    }
}
