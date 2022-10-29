using System;
using System.Collections.Generic;

namespace MenuOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            float totalCost = 0.00F;
            Dictionary<string, double> menu = new Dictionary<string, double>
            {
                {"Baja Taco:", 4.00},
                {"Burrito:", 7.50},
                {"Bowl:", 8.50},
                {"Nachos:", 11.00},
                {"Quesadilla:", 8.50},
                {"Super Burrito:", 8.50},
                {"Super Quesadilla:", 9.50},
                {"Taco:", 3.00},
                {"Tortilla Salad:", 8.00}
            };
            foreach (KeyValuePair<string, double> option in menu)
            {
                Console.WriteLine($"{option.Key} is {option.Value} dollars.");
            }
            int x = 0;
            while (x < 1)
            {
                Console.WriteLine("Enter a item: ");
                string userChoice = Console.ReadLine();

                if (userChoice == "Baja Taco")
                {
                    totalCost = totalCost + 4.00F;
                    Console.WriteLine($"Total: {totalCost:F2} $");
                }
                else if (userChoice == "Burrito")
                {
                    totalCost = totalCost + 7.50F;
                    Console.WriteLine($"Total: {totalCost:F2} $");
                }
                else if (userChoice == "Bowl")
                {
                    totalCost = totalCost + 8.50F;
                    Console.WriteLine($"Total: {totalCost:F2} $");
                }
                else if (userChoice == "Nachos")
                {
                    totalCost = totalCost + 11.00F;
                    Console.WriteLine($"Total: {totalCost:F2} $");
                }
                else if (userChoice == "Quesadilla")
                {
                    totalCost = totalCost + 8.50F;
                    Console.WriteLine($"Total: {totalCost:F2} $");
                }
                else if (userChoice == "Super Burrito")
                {
                    totalCost = totalCost + 8.50F;
                    Console.WriteLine($"Total: {totalCost:F2} $");
                }
                else if (userChoice == "Super Quesadilla")
                {
                    totalCost = totalCost + 9.50F;
                    Console.WriteLine($"Total: {totalCost:F2} $");
                }
                else if (userChoice == "Taco")
                {
                    totalCost = totalCost + 3.00F;
                    Console.WriteLine($"Total: {totalCost:F2} $");
                }
                else if (userChoice == "Super Quesadilla")
                {
                    totalCost = totalCost + 8.00F;
                    Console.WriteLine($"Total: {totalCost:F2} $");
                }
                else if (userChoice.ToLower() == "end")
                {
                    x = x + 1;
                }
                else
                {

                }
            }
        }
    }
}
