using System;
using System.Collections.Generic;
using System.Text;
using v3Complation.Core.Entities;

namespace v3Complation.Entities.Concrete
{
    public class PrItemBasePrice:BaseEntity,IEntity
    {

        //Madde fiyat tablosu
        public int ItemTypeCode { get; set; }//Primary key,Foreign key
        public virtual BsItemType BsItemType { get; set; }

        public string ItemCode { get; set; }//Primary key,Foreign key
        public virtual CdItem CdItem { get; set; }

        public int BasePriceCode { get; set; }//Primary key,Foreign key
        public virtual BsBasePrice BsBasePrice { get; set; }

        public string CurrencyCode { get; set; }//Primary key,Foreign key
        public virtual CdCurrency CdCurrency { get; set; }

        public string CountryCode { get; set; }//Primary key,Foreign key
        public virtual CdCountry CdCountry { get; set; }

        public DateTime PriceDate { get; set; }

        public decimal Price { get; set; }//money

        public Guid RowGuid { get; set; }




    }
}
