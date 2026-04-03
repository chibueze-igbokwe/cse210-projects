// Represents a product in an order
public class Product
{
    // Private fields (Encapsulation)
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructor
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Method to calculate total cost
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    // Getters
    public string GetName() => _name;
    public string GetProductId() => _productId;
}
