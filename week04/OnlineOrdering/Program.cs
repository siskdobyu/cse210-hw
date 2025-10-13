using System;
using System.Collections.Generic;

public class Product
{
    private string _name;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    public string GetProductLabel()
    {
        return $"{_name} (ID: {_productId})";
    }
}

public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.Trim().ToUpper() == "USA";
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateOrProvince}\n{_country}";
    }
}

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }
}

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;

        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping
        if (_customer.LivesInUSA())
            total += 5; // domestic shipping
        else
            total += 35; // international shipping

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";

        foreach (var product in _products)
        {
            label += $"- {product.GetProductLabel()}\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // === Customer 1 (USA) ===
        Address address1 = new Address("12th Street", "Salt Lake City", "UT", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Cellphone", "CP001", 100.00, 1));
        order1.AddProduct(new Product("Charger", "CP002", 30.00, 2));

        // === Customer 2 (International) ===
        Address address2 = new Address("Rizal Street", "Philippines", "PH", "Philippines");
        Customer customer2 = new Customer("Juan Cruz", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Speakers", "SP001", 50.00, 1));
        order2.AddProduct(new Product("Electric Fan", "EF001", 75.00, 1));
        order2.AddProduct(new Product("Cleaning Brush", "CB001", 5.00, 2));

        // === Display order details ===
        List<Order> orders = new List<Order> { order1, order2 };

        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost():F2}");
            Console.WriteLine(new string('-', 50));
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}