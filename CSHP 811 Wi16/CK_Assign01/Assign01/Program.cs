using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Charlene Kim
 * CSHP 811 B
 * Module 01 Assignment
 */
namespace Assign01
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            while (true)
            {
                bool valueValid = false;
                double value1 = 0;
                while (!valueValid)
                {
                    Console.Write("Please enter a number: ");
                    string firstNumberString = Console.ReadLine();
                    if (Double.TryParse(firstNumberString, out value1))
                    {
                        valueValid = true;
                    }
                    else
                    {
                        Console.WriteLine("You've entered an invalid number. Please try again.");
                    }
                }
                valueValid = false;
                double value2 = 0;
                while (!valueValid)
                {
                    Console.Write("Please enter another number: ");
                    string secondNumberString = Console.ReadLine();
                    if (Double.TryParse(secondNumberString, out value2))
                    {
                        valueValid = true;
                    }
                    else
                    {
                        Console.WriteLine("You've entered an invalid number. Please try again.");
                    }
                }

                Console.WriteLine("============");
                Console.WriteLine("SUM: {0}", calc.Add(value1, value2)); 
                Console.WriteLine("DIFFERENCE: {0}", calc.Subtract(value1, value2));
                Console.WriteLine("PRODUCT: {0}", calc.Multiply(value1, value2));
                double? quotient = calc.Divide(value1, value2);
                if (quotient == null)
                {
                    Console.WriteLine("QUOTIENT: undefined");
                }
                else
                {
                    Console.WriteLine("QUOTIENT: {0}", quotient);
                }
                Console.WriteLine("============");

                Console.WriteLine("Press 'q' to quit or any other key to continue...");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();
                if (key.Key == ConsoleKey.Q)
                {
                    break;
                }
            }
        }
    }
}
