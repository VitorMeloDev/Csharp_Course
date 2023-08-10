using System.Globalization;
namespace Entities
{
    class ImportedProduct : Product
    {
        public double CustumFee { get; set; }
        
        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double custumFee) : base(name, price)
        {
            CustumFee = custumFee;
            Price += CustumFee;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + " (Customs Fee: $ " + CustumFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
