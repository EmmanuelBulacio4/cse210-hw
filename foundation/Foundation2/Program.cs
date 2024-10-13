using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order N 1
        
        Address address1 = new Address("Suiza 47", "Metan", "Salta", "Argentina");

        Customer customer1 = new Customer("Juan Perez", address1);
        
        List<Product> productsList1 = new List<Product>();
 
        Product p001 = new Product("Hymnbook", "5638683644", 1.10, 25);
        productsList1.Add(p001);
        Product p002 = new Product("Youth Lucy Dress", "5638698218", 15, 3);
        productsList1.Add(p002);
        Product p003 = new Product("Preach My Gospel", "54621548", 1.99, 15);
        productsList1.Add(p003);

        Order order1 = new Order(productsList1, customer1);

        //Print Costs and Labels
        Console.WriteLine("******************************************");
        Console.WriteLine("Order Number: 1");
        Console.WriteLine($"Total Cost: {order1.TotalCostOrder()}");
        order1.PackingLabel();
        order1.ShippingLabel();


        //Order N°2
        Address address2 = new Address("Springfield st. 5123", "Meza", "AZ", "USA");

        Customer customer2 = new Customer("Mathew Smith", address2);
        
        List<Product> productsList2 = new List<Product>();
 
        Product p054 = new Product("Gaming Chair with footrest", "6818468465", 119.25, 1);
        productsList2.Add(p054);
        Product p071 = new Product("Mechanical Gaming Keybord", "1728837638", 62.90, 2);
        productsList2.Add(p071);
        Product p634 = new Product("LED wireless Mouse Slim", "B0836GXKKB", 25.10, 3);
        productsList2.Add(p634);

        Order order2 = new Order(productsList2, customer2);

        //Print Costs and Labels
        Console.WriteLine("******************************************");
        Console.WriteLine("Order Number: 2");
        Console.WriteLine($"Total Cost: {order2.TotalCostOrder()}");
        order2.PackingLabel();
        order2.ShippingLabel();


        //Order N°3
        Address address3 = new Address("Eisaguirre Av. 250", "Los Olivos", "Lima", "Peru");

        Customer customer3 = new Customer("Miguel Puertas Diaz", address3);
        
        List<Product> productsList3 = new List<Product>();
 
        Product p432 = new Product("The Pullman Strike", "book457822", 42.49, 1);
        productsList3.Add(p432);
        Product art78 = new Product("Idiot Generation: A Critique of Adolescent Centrism", "Laje4552215", 12.79, 1);
        productsList3.Add(art78);
        Product art5478 = new Product("Colmillo Branco. Jack London", "B5400zB", 15.10, 1);
        productsList3.Add(art5478);

        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("******************************************");
        Console.WriteLine("Order Number: 3\n");

        //Print Costs and Labels
        Console.WriteLine($"Total Cost: {order3.TotalCostOrder()}\n");
        order3.PackingLabel();
        order3.ShippingLabel();
    }
}