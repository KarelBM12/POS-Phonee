using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FINAL
{
    internal class Menu
    {
        private static List<string> Cart = new List<string>();
        public static void DisplayItems()
        {
            string[] items = { "Charger",
                           "Powerbank",
                           "Phonecase",
                           "Earphones",
                           "Adaptor",
                           "Headphones",
                           "SD Cards",
                           "Speakers",
                           "Samsung Phone",
                           "Realme Phone",
                           "Iphone",
                           "Xiaomi Phone",
                           "Vivo Phone",
                           "Infinix Phone",
                           "POCO x3"};


            double total = 0;
            double[] prices = {
                                150,
                                500,
                                50,
                                200,
                                520,
                                350,
                                600,
                                1000,
                                8500,
                                9000,
                                11000,
                                11500,
                                8000,
                                7500,
                                15000

            };


            Console.WriteLine("\nItems available:");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{items[i]} - {prices[i]}");
            }
        }

        public static void AddItems()
        {
            string[] items = { "Charger",
                           "Powerbank",
                           "Phonecase",
                           "Earphones",
                           "Adaptor",
                           "Headphones",
                           "SD Cards",
                           "Speakers",
                           "Samsung Phone",
                           "Realme Phone",
                           "Iphone",
                           "Xiaomi Phone",
                           "Vivo Phone",
                           "Infinix Phone",
                           "POCO x3"};

            Console.WriteLine("\nEnter the name of the item you want to buy: ");
            string input = Console.ReadLine();

            bool item = false;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == input)
                {
                    item = true;
                    Cart.Add(items[i]);
                    break;
                }
            }

            if (item)
            {
                Console.WriteLine($"The {input} is ready for check out.");
            }
            else
            {
                Console.WriteLine($"{input} is incorrect");
            }
        }


        public static void CheckOut()
        {
            double total = 0;
            string[] items = { "Charger",
                        "Powerbank",
                        "Phonecase",
                        "Earphones",
                        "Adaptor",
                        "Headphones",
                        "SD Cards",
                        "Speakers",
                        "Samsung Phone",
                        "Realme Phone",
                        "Iphone",
                        "Xiaomi Phone",
                        "Vivo Phone",
                        "Infinix Phone",
                        "POCO x3"};

            double[] prices = {
                             150,
                             500,
                             50,
                             200,
                             520,
                             350,
                             600,
                             1000,
                             8500,
                             9000,
                             11000,
                             11500,
                             8000,
                             7500,
                             15000
     };

            Console.WriteLine("\nRECEIPT: ");
            foreach (string item in Cart)
            {
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i] == item)
                    {
                        Console.WriteLine($"{items[i]} - {prices[i]}");
                        total += prices[i];
                        break;
                    }
                }
            }

            Console.WriteLine($"Total Amount: ${total}");
            Console.WriteLine("Thank you!");
        }
    }
}

























