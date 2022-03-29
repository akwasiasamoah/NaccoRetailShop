using NaccoRetailShop.Models;
using System;
using System.Collections.Generic;

namespace NaccoRetailShop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            Item item1 = new Item("Apple", 10.0m, 7.0m, "It is a fruit", 10, 0.01m);
            Item item2 = new Item("Belt", 8.0m, 5.0m, "It is a clothing ", 8, 0.02m);
            Item item3 = new Item("Fridge", 50.0m, 40.0m, "It is a product", 7, 0.05m);
            Item item4 = new Item("Laptop", 20.0m, 15.0m, "It is an electronic device", 0, 0.02m);
            items.Add(item1);
            items.Add(item2);
            items.Add(item3);

            Console.WriteLine("Nacco shop commands, Enter System or Customer: ");
            var command = Console.ReadLine().ToLower();
            if(command == "system")
            {
                Console.WriteLine("Enter Item Name: ");
                var name = Console.ReadLine();
                Console.WriteLine("Enter Item RetailPrice: ");
                var retailprice = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter Item WholeSalePrice: ");
                var wholesaleprice = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter Item Description: ");
                var desc = Console.ReadLine();
                Console.WriteLine("Enter Stock Available: ");
                var stock = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Item Discount: ");
                var discount = Convert.ToDecimal(Console.ReadLine());

                Item item = new Item(name, retailprice, wholesaleprice, desc, stock, discount);
                items.Add(item);

            }
            else if(command == "customer")
            {
                Console.Write("Enter Item Name: ");
                var itemName = Console.ReadLine();
                for(int i = 0; i < items.Count; i++)
                {
                    if(items[i].Name == itemName && items[i].Stock > 0)
                    {
                        Console.WriteLine(items[i].Name + " is available");
                    }
                }

                Console.WriteLine("Do you want to purchase Item? (Enter Y or N)");
                var purchase = Console.ReadLine();
                if(purchase == "Y")
                {
                    Console.WriteLine("Item purchased");

                }
                else
                {
                    Console.WriteLine("Come back later");
                }
            }    

        }
    }
}
