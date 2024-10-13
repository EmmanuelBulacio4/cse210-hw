using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order N 1
        Address address1 = new Address("Angamos St 125", "San Borja", "Lima", "Peru");
        Customer customer1 = new Customer("Valeria Alcala Guillen", address1);
        List<Product> productsList1 = new List<Product>();
 
        Product p001 = new Product("Graphing Calculator", "GC200", 65.99, 1);
        productsList1.Add(p001);
        Product p002 = new Product("Notebook", "NB50", 3.50, 5);
        productsList1.Add(p002);
        Product p003 = new Product("Mechanical Pencil", "MP05", 1.99, 10);
        productsList1.Add(p003);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order Number: 1");

    }
}