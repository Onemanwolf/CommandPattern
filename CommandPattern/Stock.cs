namespace CommandPattern
{
    public class Stock
    {
        private string _name;
        private int _quantity;

        public Stock(string name, int quantity)
        {
            _name = name;
            _quantity = quantity;
        }


        public void BuyStock(string orderId)
        {
             Console.WriteLine($"Stock [ Name: {_name}, Quantity: {_quantity} ] bought  OrderId: {orderId}");
        }

        public void SellStock(string orderId)
        {
            Console.WriteLine($"Stock [ Name: {_name}, Quantity: {_quantity} ] sold OrderId: {orderId}");
        }


    }
}