namespace WithoutDIP_Presentation;

public class OrderService
{
    private EmailService _emailService;
    //private SmsService _smsService;//اضافه شد

    public OrderService()
    {
        _emailService = new EmailService();//وابستگی مستقیم به کلاس سطح پایین
        //_smsService = new SmsService();//اضافه شد
    }

    public void OrderProcess(Order order)
    {
        //پردازش سفارش
        Console.WriteLine("Order is processing ....");

        //ایمیل تاییدیه
        _emailService.SendEmail(order.CustomerEmail);
        //_smsService.SendSms(/*order.PhoneNumber,*/ "DIP is vital");//OCP نقض 
    }
}