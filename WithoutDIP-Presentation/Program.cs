namespace WithoutDIP_Presentation;

class Program
{
    public static  void Main()
    {
        Console.WriteLine("---------------- Process Order ----------------");
        Console.WriteLine();
        OrderService orderService = new OrderService();
        Order order = new Order()
        {
            CustomerEmail = "******@gmail.com"
            //PhoneNumber = "123456789"
        };
        orderService.OrderProcess(order);
    }
}