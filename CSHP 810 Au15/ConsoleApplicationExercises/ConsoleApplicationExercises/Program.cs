/*
 * Name: Lorne Roy
 * Student ID: 0034514 
 */

using System;


namespace ConsoleApplicationExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            CanRack canRack = new CanRack();//this is the rack of cans in the machine with bins of original, lemon, and orange

            CoinBox coinBox = new CoinBox();

            bool quit = false;//flag used for quitting the application from a user input
            
            PurchasePrice sodaPrice = new PurchasePrice(35); //the price of the product in US cents

            string input;//input string from user


            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");
            while (true)
            {
                canRack.DisplayCanRack();

                Console.WriteLine("Please insert {0} cents (or X to exit):", sodaPrice.Price);
                while (true)
                {
                    Console.Write("Please insert a coin:");
                    input = Console.ReadLine().ToUpper();
                    if (input.ToUpper() == "X")
                    {
                        quit = true;
                        break;
                    }
                    else
                    {

                        try
                        {
                            coinBox.Deposit(new Coin(input));

                            Console.WriteLine("You have inserted {0} cents total", (int)(coinBox.ValueOf * 100));
                            if (coinBox.ValueOf >= sodaPrice.PriceDecimal)
                            {
                                Console.WriteLine("Thank you");
                                break;
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("That is not a form of currency.");
                        }

                    }
                }
                if (quit)
                {
                    break;
                }
                while (true)
                {
                    Console.WriteLine("What flavor would you like:");
                    foreach (string flavor in Enum.GetNames(typeof(Flavor)))
                    {
                        Console.WriteLine(flavor);
                    }
                    string flavorEntry = Console.ReadLine();
                    try
                    {
                        canRack.RemoveACanOf(flavorEntry);
                        Console.WriteLine("Thanks. Here is your soda.");
//no longer giving change                        Console.WriteLine("Returning {0} cents", (int)((coinBox.ValueOf - sodaPrice.PriceDecimal) * 100));
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Something is wrong");
                        Console.WriteLine(e.Message);
//no longer giving change                        Console.WriteLine("Returning {0} cents", (int)((coinBox.ValueOf) * 100));
                    }                
                }


                Console.WriteLine("There are {0} half dollars in the coinBox", coinBox.HalfDollarCount);
                Console.WriteLine("There are {0} quarters in the coinBox", coinBox.QuarterCount);
                Console.WriteLine("There are {0} dimes in the coinBox", coinBox.DimeCount);
                Console.WriteLine("There are {0} nickels in the coinBox", coinBox.NickelCount);
                Console.WriteLine("There are {0} slugs in the coinBox", coinBox.SlugCount);
                Console.WriteLine("There is {0:C} in the coinBox", coinBox.ValueOf);
                Console.WriteLine();
                
            }
        }
    }
}
