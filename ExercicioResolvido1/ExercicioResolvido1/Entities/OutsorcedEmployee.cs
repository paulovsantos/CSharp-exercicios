
namespace ExercicioResolvido1.Entities
{
    class OutsorcedEmployee : Employee
    {
        public double AddtionalCharge { get; set; }

        public OutsorcedEmployee()
        {

        }

        public OutsorcedEmployee(string name, int hours, double valuePerHour, double addtionalCharge) : base(name, hours, valuePerHour)
        {
            AddtionalCharge = addtionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AddtionalCharge;
        }
    }
}
