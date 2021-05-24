using System.Globalization;

namespace Course.Entities
{
    class Product
    {
        public string NameProduct { get; set; }
        public double PriceProduct { get; set; }

        public Product()
        {
        }

        public Product(string nameProduct, double priceProduct)
        {
            NameProduct = nameProduct;
            PriceProduct = priceProduct;
        }

        public virtual string PriceTag()
        {
            return NameProduct + " $" + PriceProduct.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
