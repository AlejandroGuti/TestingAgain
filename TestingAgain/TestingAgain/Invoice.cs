namespace TestingAgain
{
    public class Invoice : IPay
    {


        public int Id { get; set; }
        public string Description { get; set; }
        public float Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal GetValueToPay()
        {
            return Price * (decimal)Quantity;
        }
        public override string ToString()
        {
            return $"{Id} {Description}\n\t Quantity: {Quantity:N2}\n\t Price{Price:C2}\n\t Value{GetValueToPay()}";
        }
    }
}
