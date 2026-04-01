using System;

class Program
{
    static void Main()
    {
        // Create USA addresses
        Address address1 = new Address("123 Main St", "Salt Lake City", "UT");
        Address address2 = new Address("456 Elm St", "Los Angeles", "CA");

        // Create customers
        Customer customer1 = new Customer("Burhan Hassan", address1);
        Customer customer2 = new Customer("Alice Johnson", address2);

        // Create products
        Product product1 = new Product("Laptop", "L001", 1200, 1);
        Product product2 = new Product("Mouse", "M001", 25, 2);
        Product product3 = new Product("Keyboard", "K001", 45, 1);
        Product product4 = new Product("Monitor", "MON101", 200, 2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product2);

        // Display order 1 details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotal():0.00}\n");

        // Display order 2 details
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotal():0.00}\n");
    }
}