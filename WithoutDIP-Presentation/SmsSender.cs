namespace WithoutDIP_Presentation;

public class SmsSender
{
    public void SendSms(string to, string message)
    {
        Console.WriteLine($"Sending SMS to {to} = {message}");
    }
}