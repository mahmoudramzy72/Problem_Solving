using System;

namespace PS_Leetcode
{
    internal class Minimum_Number_Game
    {
        // You are given a 0-indexed integer array nums of even length and there is also an empty array arr.
        // Alice and Bob decided to play a game where in every round Alice and Bob will do one move.
        // The rules of the game are as follows:
        // Every round, first Alice will remove the minimum element from nums, and then Bob does the same.
        // Now, first Bob will append the removed element in the array arr, and then Alice does the same.
        // The game continues until nums becomes empty, Return the resulting array arr.
        public static void Run()
        {
            int[] nums = { 5, 4, 2, 3 };

            int[] result = NumberGame(nums);
            Console.WriteLine($"[{string.Join(",", result)}]");
        }

        public static int[] NumberGame(int[] nums)
        {
            Array.Sort(nums);
            int n = nums.Length;
            int[] result = new int[n];

            for (int i = 0; i < nums.Length / 2; i++)
            {
                result[i * 2] = nums[i * 2 + 1]; // Bob's turn  
                result[i * 2 + 1] = nums[i * 2]; // Alice's turn  
            }
            return result;
        }
    }
}

