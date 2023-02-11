namespace CommandPattern
{
    public class Broker
    {
        private List<IOrderCommand> _orderList = new List<IOrderCommand>();

        public void TakeOrder(IOrderCommand order)
        {
            _orderList.Add(order);
        }


        public void PlaceOrders()
        {
            foreach (IOrderCommand order in _orderList)
            {
                order.Execute();
            }

            _orderList.Clear();
        }
    }
}