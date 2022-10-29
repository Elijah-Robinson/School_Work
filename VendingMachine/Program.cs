using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int amtDue = 50;

            int coin = 0; 

            //isnumeric method to check if its numeric or not
            //has to be 1, 5, 10, 25


            while(coin < 50)
            {

                try
                {
                    Console.WriteLine("Ammount Due: " + amtDue);
                    Console.WriteLine("Insert Coin: ");
                    string inputCoin = Console.ReadLine();
                    int coin2 = Int32.Parse(inputCoin);
                        
                    if (coin2 != 1 && coin2 != 5 && coin2 != 10 && coin2 != 25)
                    {
                        Console.WriteLine("You entered something other than 1, 5, 10, or 25.");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("");
                            
                    }
                    else if (coin2 == 1 || coin2 == 5 || coin2 == 10 || coin2 == 25)
                    {
                        coin = coin + coin2;
                        amtDue = amtDue - coin2;
                    }
                }
                catch
                {
                }
            }
            int userOwed = amtDue * -1;
            Console.WriteLine("You are owed: " + userOwed + " cents back");
        }
    }
}
