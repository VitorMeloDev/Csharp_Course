
namespace Entities
{
    class Companies : TaxPayer
    {
        public int NumberEmployees { get; set; }

        public Companies(string name, double annualIncome, int numberEmployees) : base(name,annualIncome)
        { 
            NumberEmployees = numberEmployees;
        }

        public override double TaxAmount()
        {
            double value = 0;
            
            if (NumberEmployees > 10)
            {
                value = AnnualIncome / 100 * 14;
            }
            else
            {
                value = AnnualIncome / 100 * 16;
            }

            return value;

        }
    }
}
