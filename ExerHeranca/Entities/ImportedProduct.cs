using System;
using System.Collections.Generic;
using System.Text;
using ExerHeranca.Entities;

namespace ExerHeranca.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base (name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return Name + " " + Price.ToString("C") + ", (Custom fee " + CustomsFee.ToString("C") + ")";
        }
    }
}
