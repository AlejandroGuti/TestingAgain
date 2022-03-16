namespace TestingAgain
{
    public class HourlyEmployee : Employee
    {
        public float Hours { get; set; }
        public decimal HourValue { get; set; }


        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, \n\t Hours: {Hours:N2}, \n\t Hour Value: {HourValue}, \n\t Value To Pay: {$"{GetValueToPay():C2}",15}  ";
        }
    }
}
