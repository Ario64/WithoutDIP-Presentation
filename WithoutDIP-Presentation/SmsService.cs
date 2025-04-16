namespace WithoutDIP_Presentation;

public class SmsService
{
    public void SendSms(string phoneNumber, string message)
    {
        Console.WriteLine($"Sending SMS to {phoneNumber} = {message}");
    }
}