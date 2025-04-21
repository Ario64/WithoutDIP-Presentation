namespace WithoutDIP_Presentation;

public class NotificationService
{
    private EmailSender _emailSender;
    //private SmsSender _smsSender;

    public NotificationService()
    {
        _emailSender = new EmailSender();
        //_smsSender = new SmsSender();
    }

    public void Notify(string to)
    {
        _emailSender.SendEmail(to, "Payment Confirmation!");
        //_smsSender.SendSms(to, "Payment Confirmation!");
    }
}