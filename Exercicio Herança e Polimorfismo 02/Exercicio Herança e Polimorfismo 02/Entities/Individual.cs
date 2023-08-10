
namespace Entities
{
    class Individual : TaxPayer
    {
        public double HealthSecurity { get; set; }


        public Individual(string name, double annualIncome, double healthSecurity) : base(name, annualIncome)
        { 
            HealthSecurity = healthSecurity;
        }

        public override double TaxAmount()
        {
            double value = 0;

            if(AnnualIncome < 20000)
            {
                value = AnnualIncome / 100 * 15;
            }
            else
            {
                value = AnnualIncome / 100 * 25;
            }

            if (HealthSecurity > 0)
            {
                value -= HealthSecurity / 2;
            }

            return value;
        }
    }
}
