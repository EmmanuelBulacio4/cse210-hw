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
        Console.WriteLine("Packing Label: ");
        foreach (Product product in _products) 
        {
            Console.WriteLine($"{product.GetProductName()} - {product.GetProductID()}");
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine($"{_customer.GetName()}");
        Console.WriteLine($"{_customer.GetCustumerAddress()}");
    }

    // public string GenerateTotalCost()
    // {
    //     string totalCost = "\nProducts:\n";
    //     double totalPrice = CalculateTotalPrice();
    //     foreach (Product p in _products) 
    //     {
    //         totalCost += p.GetName() + " (" + p.GetProductID() + ") - " + "$" + p.GetPrice() + " x " + p.GetQuantity() + " = " + p.CalculatePrice() + "\n";
    //     }
        
    //     totalCost += "Shipping Cost: $" + CalculateShipping() + "\n";
    //     totalCost += "Total: $" + CalculateTotalPrice();
        
    //     return totalCost;
    // }

    // public void DisplayResults()
    // {
    //     string packingLabel = GeneratePackingLabel();
    //     string shippingLabel = GenerateShippingLabel();
    //     string totalCost = GenerateTotalCost();

    //     Console.WriteLine(packingLabel);
    //     Console.WriteLine(shippingLabel);
    //     Console.WriteLine(totalCost);
    // }
}