namespace CommandPattern;
class Program
{
    static void Main(string[] args)
    {
        Stock stock = new Stock("Microsoft", 10);
        var buyOrderId= "1";
        var sellOrderId= "2";
        var orderRepo = new OrderRepo();
        BuyStock buyStock = new BuyStock(stock, buyOrderId, orderRepo);
        SellStock sellStock = new SellStock(stock, sellOrderId, orderRepo);
        Broker broker = new Broker();
        broker.TakeOrder(buyStock);
        broker.TakeOrder(sellStock);
        broker.PlaceOrders();
    }
}
