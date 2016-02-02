/*
 * Name: Lorne Roy
 * Student ID: 0034514 
 * Date:06OCT2015
 * Exercise 1.2
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int sodaPrice = 35;
            //input string from user
            string input;
            //numeric representation of the input
            short inputNumber;
            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");
            Console.Write("Please insert {0} cents:", sodaPrice);
            input = Console.ReadLine();

            if(Int16.TryParse(input,out inputNumber))
            {
                Console.WriteLine("You have inserted {0} cents", inputNumber);
                Console.WriteLine("Thanks. Here is your soda.");
            }
            else
            {
                Console.WriteLine("That is not a form of currency.  Goodbye.");
            }
        }
    }
}
