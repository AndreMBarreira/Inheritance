using System;
using ExerHeranca.Entities;
using System.Collections.Generic;

namespace ExerHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
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
                if (typeProduct == 'c') 
                {
                    products.Add(new Product(name, price));
                }
                else if (typeProduct == 'i')
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(name, price, fee));
                }
                else
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime dateManufacture = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, dateManufacture));
                }
                
            }
            Console.WriteLine();
            foreach (Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
