namespace CommandPattern
{
    public class OrderRepo : IRepo<Order>
    {

        private HashSet<Order> _orders = new HashSet<Order>();
        public void Save(Order order)
        {
           _orders.Add(order);
           foreach(var o in _orders){
             Console.WriteLine($"Order saved: OrderId: {o._orderId} OrderType: {o._orderType}");

           }

        }
    }
}