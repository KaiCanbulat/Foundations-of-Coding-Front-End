using System;
using System.Collections.Generic;

class Program
{
    static List<string> productNames = new List<string>();
    static List<decimal> productPrices = new List<decimal>();
    static List<int> productStock = new List<int>();

    static void Main()
    {
        // a loop that repeats until the user chooses to exit "0"
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("=== Inventory ===");
            Console.WriteLine("1) Add product");
            Console.WriteLine("2) Display products");
            Console.WriteLine("3) Change stock");
            Console.WriteLine("4) Delete product");
            Console.WriteLine("0) Exit");
            Console.Write("Selection: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddProduct();
                    break;
                case "2":
                    ListProducts();
                    break;
                case "3":
                    ChangeStock();
                    break;
                case "4":
                    RemoveProduct();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }
    }

    static void AddProduct()
    {
        // Prompt user for product details
        Console.Write("Product name: ");
        string name = Console.ReadLine();
        
        // Validate name
        Console.Write("Price: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal price))
        {
            Console.WriteLine("Invalid price.");
            return;
        }
        // Validate price
        Console.Write("Stock: ");
        if (!int.TryParse(Console.ReadLine(), out int stock))
        {
            Console.WriteLine("Invalid stock.");
            return;
        }

        productNames.Add(name);
        productPrices.Add(price);
        productStock.Add(stock);
        Console.WriteLine("Add product.");
    }

    static void ListProducts()
    {
        // Display all products
        if (productNames.Count == 0)
        {
            Console.WriteLine("No products available.");
            return;
        }

        for (int i = 0; i < productNames.Count; i++)
        {
            Console.WriteLine($"{i}: {productNames[i]} | Price: {productPrices[i]:F2} \u20AC| Stock: {productStock[i]}");
        }
    }

    static void ChangeStock()
    {
        // Change stock of a product
        ListProducts();

        Console.Write("Product number: ");
        if (!int.TryParse(Console.ReadLine(), out int index) || index < 0 || index >= productStock.Count)
        {
            Console.WriteLine("Invalid number.");
            return;
        }

        Console.Write("Change quantity (+ or -): ");
        if (!int.TryParse(Console.ReadLine(), out int amount))
        {
            Console.WriteLine("Invalid quantity.");
            return;
        }

        if (productStock[index] + amount < 0)
        {
            Console.WriteLine("Not enough stock.");
            return;
        }

        productStock[index] += amount;
        Console.WriteLine("Stock updated.");
    }

    static void RemoveProduct()
    {
        // Remove a product
        ListProducts();

        Console.Write("Delete product number: ");
        if (!int.TryParse(Console.ReadLine(), out int index) || index < 0 || index >= productNames.Count)
        {
            Console.WriteLine("Invalid number.");
            return;
        }

        productNames.RemoveAt(index);
        productPrices.RemoveAt(index);
        productStock.RemoveAt(index);

        Console.WriteLine("Remove product.");
    }
}