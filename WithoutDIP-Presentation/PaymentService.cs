namespace WithoutDIP_Presentation;

public class PaymentService
{
    private readonly CardPayment _cardPayment;
    //private OnlinePayment _onlinePayment;

    public PaymentService()
    {
        _cardPayment = new CardPayment();
        //_onlinePayment = new OnlinePayment();
    }

    public void PayWithCard(decimal amount)
    {
        _cardPayment.Pay(amount);
    }

    //    public void OnlinePay(decimal amount)
    //    {
    //        _onlinePayment.Pay(amount);
    //    }
}