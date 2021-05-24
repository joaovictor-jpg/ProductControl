using System;
using System.Globalization;

namespace Course.Entities
{
    class ImportedProduct : Product
    {
        public Double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string nameProduct, double priceProduct, double customsFee) : base(nameProduct, priceProduct)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return PriceProduct + CustomsFee;
        }

        public override string PriceTag()
        {
            return NameProduct + " $" +  TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: $" + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
