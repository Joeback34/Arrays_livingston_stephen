using System;

namespace Arrays_livingston_stephen
{
    class Program
    {
        static void Main(string[] args) // Main Method.
        {
            Console.WriteLine("Enter a whole number for the array size."); // Asks user to enter a number.
            int arraySize = Convert.ToInt32(Console.ReadLine()); // Stores input into a integer variable.
            int[] numbers = new int[arraySize]; // Creates integer array of the size the user enters.
            int sum = 0; // summary variable.

            // Asks the user for input for all the array elements.
            for(int i = 0; i < arraySize; i++) // Loops until it reaches the array size.
            {
                Console.WriteLine("Enter a whole number to add to the array."); // Asks user to enter a number for the array.
                numbers[i] = Convert.ToInt32(Console.ReadLine()); // Converts string from the user input.
                sum += numbers[i]; // Adds all elements in the array with the sum.
               
            }

            Console.WriteLine($"The sum of the array is {sum}\n"); // Prints the sum to the console.

            Array.Sort(numbers); // Sorts the numbers in the array.

            foreach(int number in numbers) // Loops though the array.
            {
                Console.WriteLine(number); // Prints the results to console.
            }
        }   

    }
}
