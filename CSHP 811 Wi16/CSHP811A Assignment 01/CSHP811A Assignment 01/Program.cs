/*
 * Lorne Roy
 * 0034514
 * CSHP811 Assignment 01
 * 17JAN2015
 * This program provides a simple calculator that can perform 4 basic math functions
 */

using System;

namespace CSHP811A_Assignment_01
{
    class Program
    {
        //the string to exit the program
        private const string exitString = "";
        
        static void Main(string[] args)
        {
            //used to store the user entry
            string userEntry = string.Empty;

            //used to store the numbers
            decimal number1;
            decimal number2;

            decimal result;
 
            char[] operators = { '+', '-', '*', '/' };

            Console.WriteLine("Please enter an expression (such as 1+1), then press the enter key");
            Console.WriteLine("Or press the enter key to exit");

            //continue to take numbers to calculate until the user exits
            while (true)
	        {

                Console.Write("Enter expression: ");

                userEntry = Console.ReadLine();

                //check if exit string entered
                if (userEntry == exitString)
                {
                    break;
                }

                try
                {
                   
                    //evaluate the input for an expression that can be calculated
                    string[] splitString = userEntry.Split(operators);

                    if (splitString.Length != 2)
                    {
                        Console.WriteLine("Invalid Expression");
                        continue;
                    }
                    if (!decimal.TryParse(splitString[0].Trim(), out number1))
                    {
                        Console.WriteLine("Invalid Expression");
                        continue;
                    }
                    if (!decimal.TryParse(splitString[1].Trim(), out number2))
                    {
                        Console.WriteLine("Invalid Expression");
                        continue;
                    }


                    //calculate the result based on the operator
                    if (userEntry.Contains("+"))
                    {
                        result = Calculation.add(number1, number2);
                    }
                    else if (userEntry.Contains("-"))
                    {
                        result = Calculation.subtract(number1, number2);
                    }
                    else if (userEntry.Contains("*"))
                    {
                        result = Calculation.multiply(number1, number2);
                    }
                    else if (userEntry.Contains("/"))
                    {
                        result = Calculation.divide(number1, number2);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Expression");
                        continue;
                    }

                    //display the result
                    Console.WriteLine(userEntry+"="+result);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Expression");                  
                }

	
            
            } 

        }
    }
}
