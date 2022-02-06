namespace SingleResponsibilityPrinciple
{
    public class Order
    {
        /*
            1-
        */
        public int OrderId { get; set; }

        public string? ProductName { get; set; }

        public string? ProductDesc { get; set; }

        public decimal Price { get; set; }

        public string? CustomerName { get; set; }

        public string? CustomerAdress { get; set; }

        public string? CustomerAdressOfWork { get; set; }

        public decimal? WalletBalance { get; set; }

        public string? CouponCode { get; set; }

        public DateTime OrderDateTime { get; set; }

        public void OrderConfirmation(Order order)
        {
            /* Scenario - Base Cases
            -> Product Details name - desc - price etc.
            -> Customer Details fname - lname etc.
            -> Payment Details Cash - Credit Card - Wallet 
            -> Shipping Details Fast Ship - Regular Ship - Free Ship 
            */
        }

        public void OrderValidation(Order order)
        {
            /* Scenario - Base Cases
            -> Product is still available in stock ?
            -> Customer has an validated address.
            */
        }
    }
}
