namespace SingleResponsibilityPrinciple
{
    public class Order
    {
        public int OrderId { get; set; }

        public string? ProductName { get; set; }

        public string? CustomerName { get; set; }

        public string? CustomerAdress { get; set; }

        public string? CustomerAdressOfWork { get; set; }

        public DateTime OrderDateTime { get; set; }

        public void OrderConfirmation(Order order)
        {
            /* Scenario - Base Cases
            -> Product Details name - desc - price etc.
            -> Customer Details fname - lname etc.
            -> Payment Details Cache - Credit Card - Wallet 
            -> Shipping Details Fast Ship - Regular Ship - Free Ship 
            */
        }
    }
}
