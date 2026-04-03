using System;

class Program
{
    static void Main(string[] args)
    {
        // -----------------------------
        // ORDER 1 (USA Customer)
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P1001", 800, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 20, 2));

        // -----------------------------
        // ORDER 2 (International Customer)
        Address address2 = new Address("45 Admiralty Way", "Lekki", "Lagos", "Nigeria");
        Customer customer2 = new Customer("Chibueze", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P2001", 500, 1));
        order2.AddProduct(new Product("Headphones", "P2002", 50, 2));

        // -----------------------------
        // DISPLAY RESULTS

        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");

        Console.WriteLine("\n===== ORDER 2 =====");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}
