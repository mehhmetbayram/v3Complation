using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Core.Entities;

namespace v3Complation.Entities.Concrete
{
    public class CdLanguage:IEntity
    {

        public CdLanguage()
        {
            this.BsBasePrices = new HashSet<BsBasePrice>();
            this.CdCurrencies = new HashSet<CdCurrency>();
            this.CdCountries = new HashSet<CdCountry>();
       
        }

        public string LanguageCode { get; set; }
        public string LanguageDescription { get; set; }
        public Guid RowGuid { get; set; }

        public virtual ICollection<BsBasePrice> BsBasePrices { get; set; }
        public virtual ICollection<CdCurrency> CdCurrencies { get; set; } 
        public virtual ICollection<CdCountry> CdCountries { get; set; }
      
    }
}
