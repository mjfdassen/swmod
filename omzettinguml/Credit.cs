public class Credit : Payment
{
    private String number = "";
    private String type = "";
    private DateTime expDate = DateTime.Now;
    public void authorized()
    {
        //authorized mastercard
    }
}