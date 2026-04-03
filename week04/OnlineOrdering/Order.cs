using System.Collections.Generic;
using System.Text;

// Represents an order
public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Add product to order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculate total cost
    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping cost
        if (_customer.LivesInUSA())
            total += 5;
        else
            total += 35;

        return total;
    }

    // Packing label
    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();

        foreach (Product product in _products)
        {
            label.AppendLine($"{product.GetName()} (ID: {product.GetProductId()})");
        }

        return label.ToString();
    }

    // Shipping label
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
