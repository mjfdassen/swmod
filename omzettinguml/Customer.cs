using System.Xml.Linq;

public class Customer
{
    private String name = "";
    private String address = "";
    List<Order> orders = new List<Order>();
    public Customer(string name, string address)
    {
        this.name = name;
        this.address = address;
    }
    public void setName (String inName)
    { this.name = inName; }
    public void setAddress (String inAddress)
    { this.address = inAddress; }
    public String getAddress()
    { return address; }
    public String getName()
    { return name; }
}