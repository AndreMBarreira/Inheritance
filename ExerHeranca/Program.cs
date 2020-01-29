using System;
using ExerHeranca.Entities;
using System.Collections.Generic;

namespace ExerHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            ImportedProduct imported = new ImportedProduct();
            UsedProduct used = new UsedProduct();

            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char typeProduct = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                product = new Product(name, price);
                if (typeProduct == 'i')
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine());
                    imported = new ImportedProduct(name, price, fee);
                    product = imported;
                }
                else if (typeProduct == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime dateManufacture = DateTime.Parse(Console.ReadLine());
                    used = new UsedProduct(name, price, dateManufacture);
                    product = used;
                }
                products.Add(product);
            }
            Console.WriteLine();
            foreach (Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
