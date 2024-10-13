using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products;


    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double TotalCostOrder()
    {
        double totalprice = 0;

        foreach (Product p in _products) 
        {
            double price = p.CalculateProductPrice();
            totalprice += price;
        }

        double shippingCost = ShippingCost();
        totalprice = totalprice + shippingCost;
        return totalprice;
    }

    public double ShippingCost() 
    {
        double shippingPrice;

        if (_customer.ItIsFromUSA())
        {
            shippingPrice = 5;
        }
        else
        {
            shippingPrice = 35;
        }
        return shippingPrice;
    }

    public void PackingLabel()
    {
        Console.WriteLine("\n***Packing Label: ***\n");
        foreach (Product product in _products) 
        {
            Console.WriteLine($"{product.GetProductName()} - {product.GetProductID()}");
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine("\n*** Shipping Label: ***");
        Console.WriteLine($"{_customer.GetName()}");
        Console.WriteLine($"{_customer.GetCustumerAddress()}");
    }

}