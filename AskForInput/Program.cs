using System;

class Program
{

    /// <summary>
    /// This program will ask the user to input a integer and a real number, then it will sum them.
    /// </summary>
    static void Main()
    {
        // Ask the user to input an integer
        Console.Write("Enter an integer: ");
        string inputInt = Console.ReadLine();

        // Convert the string to an integer
        if (int.TryParse(inputInt, out int integerValue))
        {
            // Step 3: Ask the user to input a real number
            Console.Write("Enter a real number: ");
            string inputReal = Console.ReadLine();

            // Convert the string to a real number (float)
            if (float.TryParse(inputReal, out float realNumber))
            {
                // Display the sum of the two numbers
                float sum = integerValue + realNumber;
                Console.WriteLine($"The sum of the numbers is: {sum}");
            }
            else
            {
                Console.WriteLine("Invalid real number. Make sure to enter a valid number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid integer. Make sure to enter a valid number.");
        }
    }
}
