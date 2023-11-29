using System;
using System.Collections.Generic;

public class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
}

public class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>()
        {
            new Product { ProductID = 1, ProductName = "Product A", Price = 10.00m },
            new Product { ProductID = 2, ProductName = "Product B", Price = 15.00m },
            new Product { ProductID = 3, ProductName = "Product C", Price = 20.00m }
        };

        Console.WriteLine("Welcome to our Departmental Store");

        foreach (var product in products)
        {
            Console.WriteLine($"Product ID {product.ProductID}, Name {product.ProductName}, Price {product.Price}");
        }
    }
}