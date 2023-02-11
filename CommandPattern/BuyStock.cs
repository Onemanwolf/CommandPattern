namespace CommandPattern
{
    public class BuyStock : IOrderCommand
    {

        private Stock _stock;
        private string _orderId;
        private readonly IRepo<Order> _repo;

        public BuyStock(Stock stock, string orderId, IRepo<Order> repo)
        {
            _repo = repo;
            _stock = stock;
            _orderId = orderId;
        }


        public void Execute()
        {

            _stock.BuyStock(_orderId);
            var order = new Order(_orderId, _stock, OrderType.Buy);
            SaveOrder(order);
        }

        private void SaveOrder(Order order)
        {
            _repo.Save(order);
        }
    }
}