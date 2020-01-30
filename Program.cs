// Programmer: David Uldrich
// Date: 01/30/2020
// Project: D2_IterativeStatements
// Description: Display looped message to user

using System;

namespace D2_IterativeStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display message asking for user input
            Console.WriteLine("Enter an integer between 1 and 100...");

            // Initiate Try-Catch to validate user input
            try
            {
                // Read user input as a string
                string input = Console.ReadLine();

                // Parse user input into an integer value
                int value_of_input = int.Parse(input);

                // Declare count variable for the iterative loop
                int count = 1;

                // Initiate if conditional to disqualify values not between 1-100
                if ((value_of_input <= 100) & (value_of_input >= 1))
                {
                    // Initiate while loop to display message and increment the count
                    while (count <= value_of_input)
                    {
                        // Display loop message
                        Console.WriteLine("You have entered " + value_of_input.ToString() + ". This is the current integer value in the loop: " + count.ToString());
                        count++;
                    }

                    // Display exit message to user after the loop has finished
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey(true);
                }
                // Display error for value not between 1-100
                else
                {
                    Console.WriteLine("You entered an invalid value. Next time, enter an integer between 1 and 100.");
                    Console.WriteLine("Press any key to exit and try again...");
                    Console.ReadKey(true);
                }
            }
            // Display error message for invalid user input
            catch
            {
                Console.WriteLine("You entered an invalid value. Next time, enter an integer between 1 and 100.");
                Console.WriteLine("Press any key to exit and try again...");
                Console.ReadKey(true);
            } // End of Catch
        } // End of Main
    } // End of Class
} // End of Namespace
