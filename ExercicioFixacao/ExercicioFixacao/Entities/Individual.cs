
namespace ExercicioFixacao.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        

        public override double Tax()
        {
            if(AnualIncome < 20000)
            {
                return  _ = AnualIncome * 0.15 - HealthExpenditures * 0.5;

             } else
            {
               return  _ = AnualIncome * 0.25 - HealthExpenditures * 0.5;
            }
           
        }
        /*
        public override string ToString()
        {
            return Name
                + "$"
                + AnualIncome.ToString("F2", CultureInfo.InvariantCulture);
        }
        */
    }
}
