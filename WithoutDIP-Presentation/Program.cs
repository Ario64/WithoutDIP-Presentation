namespace WithoutDIP_Presentation;

class Program
{
    public static void Main()
    {
        Console.WriteLine("---------------- Process Order ----------------");
        Console.WriteLine();

        PaymentService paymentMethod = new PaymentService();
        NotificationService notification = new NotificationService();

        Order order = new Order()
        {
            CustomerEmail = "******@gmail.com"
            //PhoneNumber = "123456789"
        };

        Console.WriteLine("You Total Order is: 750000");
        Console.WriteLine();
        //Console.WriteLine("Please Choose an Option for Payment: (1- Payment with card. 2- Payment Online)");

        paymentMethod.PayWithCard(750000);
        notification.Notify(order.CustomerEmail);

        //int paymentOption = int.Parse(Console.ReadLine()!);
        //int notificationOption = int.Parse(Console.ReadLine()!);
        //if (paymentOption == 1)
        //{
            //paymentMethod.PayWithCard(750000);
            //notification.Notify(order.CustomerEmail);
        //}
        //else
        //{
        //    paymentMethod.OnlinePay(750000);
        //    notification.Notify(order.CustomerEmail);
        //}


    }
}