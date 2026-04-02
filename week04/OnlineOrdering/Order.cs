using System;
using System.Text;
using System.Collections.Generic;  // <-- needed for List<T>

class Order
{
    private Customer _customer;
    private List<Product> _products;
    private double _shippingCost;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
        // Shipping cost is $5 if USA, $35 otherwise
        _shippingCost = _customer.LivesInUSA() ? 5.0 : 35.0;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Returns a packing label: lists product name and ID
    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder("Packing Label:\n");
        foreach (Product p in _products)
        {
            label.AppendLine($"{p.GetName()} (ID: {p.GetProductId()})");
        }
        return label.ToString();
    }

    // Returns a shipping label: customer name and address
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }

    // Calculates total order cost: sum of product totals + shipping
    public double CalculateTotal()
    {
        double total = _shippingCost;
        foreach (Product p in _products)
        {
            total += p.CalculateTotalCost();
        }
        return total;
    }
}