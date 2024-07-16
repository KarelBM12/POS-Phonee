using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Xml.XPath;
using FINAL;

namespace POSPhone
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string LoginChoice;
            Console.WriteLine("Enter Username to Continue: ");
            LoginChoice = Console.ReadLine();
            
            //USERNAME SHOULD BE 'user'
            if (LoginChoice == "user")
            {
                Console.WriteLine("\nHello!");
                bool Continue = true;

                while (Continue)
                {
                    //Menu 
                    Console.WriteLine("\nWelcome to Phone Store");
                    Console.WriteLine("Please Select to do:");

                    Console.WriteLine("1. Check Items");
                    Console.WriteLine("2. Add item");
                    Console.WriteLine("3. Check out");
                    Console.WriteLine("4. View most sold items in the store");

                    string menuItem;
                    menuItem = Console.ReadLine();


                    //Calling the options in the menuItem
                    switch (menuItem)
                    {
                        case "1":
                            Menu.DisplayItems();
                            break;
                        case "2":
                            Menu.AddItems();
                            break;
                        case "3":
                            Menu.CheckOut();
                            break;
                        case "4":
                            Sold.MostSold();
                            break;
                        default:
                            Console.WriteLine("Comeback next time");
                            break;
                    }
                }
            }


            else
            {
                Console.WriteLine("\nYou are not able to enter for now.");
                      }       
                }
            }
        }












