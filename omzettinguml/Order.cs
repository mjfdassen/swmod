public class Order
{
    DateTime date;
    String status = "";
    List<Payment> payments = new List<Payment>();
    Customer customer = null;
    List<OrderDetail> orderdetails = new List<OrderDetail>();
    public Order()
    {
        //niks
    }

    public void calcSubTotal()
    {
        //nog implementeren
    }
    public void calcTax()
    {
        //nog implementeren
    }
    public void calcTotal()
    {
        //nog implementeren
    }
    public void calcTotalWeight()
    {
        //nog implementeren
    }
}