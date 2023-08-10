﻿using System.Reflection.Metadata;
using System.Globalization;

namespace Entities
{
    class UsedProduct : Product
    {
        public DateTime Date { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime date) : base(name,price)
        {
            Date = date;
        }

        public override string PriceTag()
        {
            return Name + " (used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + " (Manufacture date: " + Date.ToString("dd/mm/yyyy") + ")";
        }
    }
}
