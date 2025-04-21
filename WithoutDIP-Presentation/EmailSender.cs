namespace WithoutDIP_Presentation;

public class EmailSender
{
    public void SendEmail(string to, string message)
    {
        Console.WriteLine($"sending email to '{to}' : {message}");
    }
}