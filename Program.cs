/*
 Author: Jesse Schmitt
 Date: 1/30/2020
 Comments: This is my deliverable 2 interative statement
 */ 

using System;

namespace Deliverable2_IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
                // Ask the user for input
            Console.Write("Enter an Interger between 1 and 100...");
            // Try catch block to validate user input
            try
            {
                //Gather user input
                string input = Console.ReadLine();
                // Variable used to perform the interative statement
                int value_of_input = int.Parse(input);
                // Conditional IF/ELSE IF/ELSE statement
                if ((value_of_input <= 100) & (value_of_input >= 1))
                {
                    // Creates Variable for count
                    int count = 1;
                    // Initate loop
                    while (count <= value_of_input)
                    {
                        Console.WriteLine("You have entered " + value_of_input.ToString() + ". This is the curent interger value in the loop: " + count.ToString());
                        count++;

                    }
                    // Display exit message
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey(true);
                }
                // Display error for value not between 1-100
                else
                {
                    Console.WriteLine("Invalid Value");
                    Console.WriteLine("Press any key to exit and try again");
                    Console.ReadKey(true);
                }


            }
            catch
            {
                Console.WriteLine("Invalid Value");
                Console.WriteLine("Press any key to exit and try again");
                Console.ReadKey(true);
            }

        }
    }
}
