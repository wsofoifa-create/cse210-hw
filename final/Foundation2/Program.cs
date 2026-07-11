using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA Customer)

        Address address1 = new Address(
            "123 Main Street",
            "Dallas",
            "Texas",
            "USA");

        Customer customer1 = new Customer(
            "John Smith",
            address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product(
            "Laptop",
            "P100",
            850.00,
            1));

        order1.AddProduct(new Product(
            "Wireless Mouse",
            "P101",
            25.00,
            2));

        order1.AddProduct(new Product(
            "Keyboard",
            "P102",
            40.00,
            1));



        // Order 2 (International Customer)

        Address address2 = new Address(
            "456 Queen Street",
            "Toronto",
            "Ontario",
            "Canada");

        Customer customer2 = new Customer(
            "Emily Brown",
            address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product(
            "Monitor",
            "P200",
            300.00,
            2));

        order2.AddProduct(new Product(
            "USB Cable",
            "P201",
            12.50,
            4));



        // Display Order 1

        Console.WriteLine("==================================");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("==================================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");



        // Display Order 2

        Console.WriteLine("\n==================================");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("==================================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}