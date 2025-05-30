using System;

class Program
{
    static void Main(string[] args)
    {
        //Create customers with addresses
        Customer customer1 = new Customer("Alice Johnson", new Address("123 Main St", "New York", "NY", "USA"));
        Customer customer2 = new Customer("Carlos Silva", new Address("456 Avenida Paulista", "São Paulo", "SP", "Brazil"));

        //Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "A123", 799.99, 1));
        order1.AddProduct(new Product("Mouse", "B456", 25.50, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Tablet", "C789", 499.99, 1));
        order2.AddProduct(new Product("Keyboard", "D101", 45.00, 1));

        //Display order details

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.GetTotalPrice()}");

        Console.WriteLine("\n----------------------\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.GetTotalPrice()}");
    }
}
