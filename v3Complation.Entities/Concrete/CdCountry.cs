using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Core.Entities;

namespace v3Complation.Entities.Concrete
{
    public class CdCountry:BaseEntity,IEntity
    {
        //Ulke tablosu

        public CdCountry()
        {
            this.PrItemBasePrices = new HashSet<PrItemBasePrice>();
        }
        public string CountryCode { get; set; }//Primary key
        public string CountryDescription { get; set; }


        public string CurrencyCode { get; set; }//Foreign key
        public virtual CdCurrency CdCurrency { get; set; }


        public string LanguageCode { get; set; }
        public virtual CdLanguage CdLanguage { get; set; }

        public Guid RowGuid { get; set; }

        public virtual ICollection<PrItemBasePrice> PrItemBasePrices { get; set; }


    }
}
