using System;
using System.Collections.Generic;

Customer customer1 = new Customer("Alice Johnson", new Address("123 Main St", "New York", "NY", "USA"));
Customer customer2 = new Customer("Bob Smith", new Address("456 Elm St", "London", "Greater London", "UK"));

Product product1 = new Product("Laptop", "L001", 1200, 1);
Product product2 = new Product("Mouse", "M001", 25, 2);
Product product3 = new Product("Keyboard", "K001", 75, 1);
Product product4 = new Product("Monitor", "MN01", 300, 1);

Order order1 = new Order(customer1);
order1.AddProduct(product1);
order1.AddProduct(product2);

Order order2 = new Order(customer2);
order2.AddProduct(product3);
order2.AddProduct(product4);

List<Order> orders = new List<Order> { order1, order2 };

foreach (Order order in orders)
{
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Packing Label:");
    Console.WriteLine(order.GetPackingLabel());
    Console.WriteLine("Shipping Label:");
    Console.WriteLine(order.GetShippingLabel());
    Console.WriteLine($"Total Price: ${order.CalculateTotalCost():0.00}");
    Console.WriteLine();
}
