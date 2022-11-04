namespace pizzaportal.Models
{
    public class Check
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public double TotalPrice { get; set; }

    }
}
