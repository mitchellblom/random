using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {

            // generate a list of 20 random numbers that are in the range of 1-50.

            Random random = new Random();

            // Create a list

            List<int> randomNumbers = new List<int>();
            List<int> squaredNumbers = new List<int>();
            List<int> squaredEvenNumbers = new List<int>();


            // Populate the list

            for (int i = 0; i < 10; i++) {
                randomNumbers.Add(random.Next(1, 20));
            }
    
            // With the resulting List, populate a new List that contains each number squared. For example, if the original list is `2, 5, 3, 15`, the final list will be `4, 25, 9, 225`.
            
            Console.WriteLine("Random Numbers: ");
            foreach (int number in randomNumbers) {
                Console.WriteLine(number);
                squaredNumbers.Add(number * number);
            }

            // Then remove any number that is odd from the list of squared numbers.

            Console.WriteLine("Squared Random Numbers: ");
            foreach (int number in squaredNumbers) {
                Console.WriteLine(number);
                if (number%2 == 0) {
                    squaredEvenNumbers.Add(number);
                }
            }

            Console.WriteLine("Squared Even Random Numbers: ");
            foreach (int number in squaredEvenNumbers) {
                Console.WriteLine(number);
            }

        }
    }
}
