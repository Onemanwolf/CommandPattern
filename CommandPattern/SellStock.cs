namespace CommandPattern
{
    public partial class SellStock : IOrderCommand
    {
        private Stock _stock;
        private string _orderId;
        private Order _order;
        private IRepo<Order> _repo;

        public SellStock(Stock stock, string orderId, IRepo<Order> repo)
        {
            _stock = stock;
            _orderId = orderId;
            _repo = repo;
        }

        public void Execute()
        {
            _stock.SellStock(_orderId);
            _order = new Order(_orderId, _stock, OrderType.Sell);
            SaveOrder(_order);


        }

        public void SaveOrder(Order order)
        {
            _repo.Save(order);
        }
    }
}