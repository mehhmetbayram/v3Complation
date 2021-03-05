using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Core.Entities;

namespace v3Complation.Entities.Concrete
{
    public class CdCurrency:BaseEntity,IEntity
    {

        //Para Birim tablosu
        public CdCurrency()
        {
            this.PrItemBasePrices = new HashSet<PrItemBasePrice>();
            this.CdCountries = new HashSet<CdCountry>();
        }
        public string CurrencyCode { get; set; }
        public string CurrencyDescription { get; set; }
        public Guid RowGuid { get; set; }

        public string LanguageCode { get; set; }
        public virtual CdLanguage CdLanguage { get; set; }

        public virtual ICollection<PrItemBasePrice> PrItemBasePrices { get; set; }
        public virtual ICollection<CdCountry> CdCountries { get; set; }
    }
}
