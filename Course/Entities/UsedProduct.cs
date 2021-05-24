using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string nameProduct, double priceProduct, DateTime manufactureDate) : base(nameProduct, priceProduct)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + " (Manufacture date: " + ManufactureDate.ToString("dd/mm/yyyy") + ")";
        }
    }
}
