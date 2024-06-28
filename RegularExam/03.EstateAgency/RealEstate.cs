namespace EstateAgency;

public class RealEstate
{
    private string address;
    private string postalCode;
    private decimal price;
    private double size;

    public RealEstate(string address, string postalCode, decimal price, double size)
    {
        this.address = address;
        this.postalCode = postalCode;
        this.price = price;
        this.size = size;
    }

    public string Address { get => address; set => address = value; }
    public string PostalCode { get => postalCode; set => postalCode = value; }
    public decimal Price { get => price; set => price = value; }
    public double Size { get => size; set => size = value; }

    public override string ToString()
    {
        return $"Address: {address}, PostalCode: {postalCode}, Price: ${price}, Size: {size} sq.m.";
    }
}
