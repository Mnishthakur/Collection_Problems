using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection_Problem
{
    public class FruitSeller
    {
        public static int MaximizeSellingPrice(int N, int K, List<int> basketA, List<int> basketB)
        {
            // Check for invalid inputs
            if (N <= 0 || K < 0 || basketA.Count != N || basketB.Count != N)
            {
                throw new ArgumentException("Invalid input");
            }

            // Sort basket A in ascending order
            basketA.Sort();

            // Sort basket B in descending order
            basketB.Sort();
            basketB.Reverse();

            // Perform at most K swaps
            for (int i = 0; i < K; i++)
            {
                if (i < N && basketA[i] < basketB[i])
                    basketA[i] = basketB[i];
                else
                    break;
            }

            // Calculate the total selling price of basket A
            int totalPrice = basketA.Sum();

            return totalPrice;
        }

        public static void Main()
        {
            try
            {
                // Read input
                Console.WriteLine("Enter the number of fruits in each basket (N K):");
                string[] input1 = Console.ReadLine().Split(' ');
                int N = int.Parse(input1[0]); // Number of fruits in each basket
                int K = int.Parse(input1[1]); // Maximum number of swaps

                Console.WriteLine("Enter the selling prices of fruits in basket A:");
                List<int> basketA = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); // Selling prices of fruits in basket A

                Console.WriteLine("Enter the selling prices of fruits in basket B:");
                List<int> basketB = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); // Selling prices of fruits in basket B

                int maxSellingPrice = MaximizeSellingPrice(N, K, basketA, basketB);
                Console.WriteLine("The maximum selling price of the basket A: " + maxSellingPrice);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
