namespace CommandPattern
{
    public class Order
    {
        public string _orderId;
        public Stock _stock {get; set;}
        public OrderType _orderType;

        public Order(string orderId, Stock stock, OrderType orderType)
        {
            _orderId = orderId;
            _stock = stock;
            _orderType = orderType;
        }

    }
}