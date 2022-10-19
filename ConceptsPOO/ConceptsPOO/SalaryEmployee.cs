namespace ConceptsPOO
{
    public class SalaryEmployee : Employee
    {
        public Decimal Salary { get; set; }
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $" \n\tValue to Pay: {GetValueToPay()}";
        }
    }
}
